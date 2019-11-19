using SatinAlma.BusinessLayer.Abstract;
using SatinAlma.BusinessLayer.Concrete;
using SatinAlma.BusinessLayer.DependencyResolvers.Ninject;
using SatinAlma.DataAccesLayer.Concrete.EntityFramework;
using SatinAlma.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SatinAlimForm : Form
    {
        public SatinAlimForm()
        {
            InitializeComponent();
            _urunlerService = InstanceFactory.GetInstance<IUrunlerService>();
            _tedarikcilerService = InstanceFactory.GetInstance<ITedarikcilerService>();
            _urunSatinAlimService = InstanceFactory.GetInstance<IUrunSatinAlimService>();
            _satinAlmaDetayService = InstanceFactory.GetInstance<ISatinAlmaDetayService>();
        }
        private IUrunlerService _urunlerService;
        private ITedarikcilerService _tedarikcilerService;
        private IUrunSatinAlimService _urunSatinAlimService;
        private ISatinAlmaDetayService _satinAlmaDetayService;
        SatinAlmaContext context = new SatinAlmaContext();
        private void SatinAlimForm_Load(object sender, EventArgs e)
        {
            cmbSatinAlimDurum.DataSource = context.SiparisDurumus.ToList();
            cmbSatinAlimDurum.DisplayMember = "SiparisDurum";
            cmbSatinAlimDurum.ValueMember = "DurumID";

            dataGridView1.DataSource = _urunlerService.Listele().Join(context.Kategorilers, u => u.KategoriID, k => k.KategoriID, (urn, kat) => new
            {
                urn,
                kat
            }).Join(context.Tedarikcilers, u => u.urn.TedarikciID, t => t.TedarikciID, (urn, ted) => new
            {
                urn.urn,
                urn.kat,
                ted
            }).Select
            (
                x => new
                {
                    x.urn.UrunID,
                    x.urn.Adi,
                    x.urn.Fiyat,
                    Stoku=x.urn.Stok,
                    x.kat.KategoriID,
                    KategoriAdi = x.kat.Adi,
                    x.ted.TedarikciID,
                    x.ted.SirketAdi
                }
                ).ToList();
            dataGridView1.Columns["KategoriID"].Visible = dataGridView1.Columns["TedarikciID"].Visible = false;

            cmbPersonel.Items.Add(PersonellerManager.Aktif.Adi);
            cmbPersonel.SelectedIndex = 0;



        }

        int id;
        private void btnSatinAlimKaydet_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow==null)
            {
                MessageBox.Show("Lütfen Satın Almak İstediğiniz Ürünü Seçiniz.");
                return;
            }
            else
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = PersonellerManager.Aktif.Adi.ToString();
                lvi.SubItems.Add(dataGridView1.CurrentRow.Cells["SirketAdi"].Value.ToString());
                lvi.SubItems.Add(DateTime.Now.ToString());
                lvi.SubItems.Add(nudNakliyeUcreti.Value.ToString());
                lvi.SubItems.Add(nudFiyat.Value.ToString());
                lvi.SubItems.Add(nudAdet.Value.ToString());
                lvi.Tag = dataGridView1.CurrentRow.Cells[0].Value;
                if (PersonellerManager.Aktif.AlisYetkiliMi==true)
                {
                    listView1.Items.Add(lvi);
                }

                UrunSatinAlim urunSatinAlim = new UrunSatinAlim();
                urunSatinAlim.PersonelID = PersonellerManager.Aktif.PersonelID;
                urunSatinAlim.TedarikciID = (int)dataGridView1.CurrentRow.Cells["TedarikciID"].Value;
                urunSatinAlim.SatinAlimTarihi = DateTime.Now;
                urunSatinAlim.NakliyeUcreti = nudNakliyeUcreti.Value;
                if (PersonellerManager.Aktif.AlisYetkiliMi == true)
                {

                    _urunSatinAlimService.Ekle(urunSatinAlim);
                    id = urunSatinAlim.SatinAlimID;
                }
                else
                {
                    MessageBox.Show("Satın Almaya Yetkiniz Yoktur.");
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                SatinAlmaDetay sad = new SatinAlmaDetay();
                sad.SatinAlimID = id;
                sad.UrunID = (int)item.Tag;
                sad.DurumID = (int)cmbSatinAlimDurum.SelectedValue;
                sad.Fiyat = Convert.ToDecimal(item.SubItems[4].Text);
                sad.Adet = Convert.ToDouble(item.SubItems[5].Text);
                sad.AlinmaTarihi = DateTime.Now;

                if (sad.DurumID==3)
                {
                    _satinAlmaDetayService.EkleDetay(sad);
                }
                else
                {
                    MessageBox.Show("Satın Alım Reddedildi.");
                }
                
                
            }

        }
    }
}
