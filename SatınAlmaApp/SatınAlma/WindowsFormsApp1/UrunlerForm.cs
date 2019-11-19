using SatinAlma.BusinessLayer.Abstract;
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
    public partial class UrunlerForm : Form
    {
        public UrunlerForm()
        {
            InitializeComponent();
            _urunlerService = InstanceFactory.GetInstance<IUrunlerService>();
            _tedarikcilerService = InstanceFactory.GetInstance<ITedarikcilerService>();
            _kategorilerService = InstanceFactory.GetInstance<IKategorilerService>();
        }

        private IUrunlerService _urunlerService;
        private ITedarikcilerService _tedarikcilerService;
        private IKategorilerService _kategorilerService;
        private  SatinAlmaContext context;
        private void UrunlerForm_Load(object sender, EventArgs e)
        {
            HandleException(
                () =>
                {
                    UrunListele();
                    TedarikciListele();
                    KategoriListele();
                }
                );
        }

        private void TedarikciListele()
        {
            cmbTedarikciler.DataSource = _tedarikcilerService.Listele();
            cmbTedarikciler.DisplayMember = "SirketAdi";
            cmbTedarikciler.ValueMember = "TedarikciID";
        }

        private void KategoriListele()
        {
            cmbKategoriler.DataSource = _kategorilerService.Listele();
            cmbKategoriler.DisplayMember = "Adi";
            cmbKategoriler.ValueMember = "KategoriID";
        }

        private  void UrunListele()
        {
            if (context == null)
            {
                context = new SatinAlmaContext();
            }
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
                    x.urn.Stok,
                    x.kat.KategoriID,
                    KategoriAdi = x.kat.Adi,
                    x.ted.TedarikciID,
                    x.ted.SirketAdi
                }
                ).ToList();

            dataGridView1.Columns["KategoriID"].Visible = dataGridView1.Columns["TedarikciID"].Visible = false;
            
        }
        

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            HandleException(() =>
            {
                _urunlerService.Ekle(new Urunler
                {
                    Adi = txtUrunAdi.Text,
                    Fiyat = nudFiyat.Value,
                    Stok = (short)nudStok.Value,
                    KategoriID = (int)cmbKategoriler.SelectedValue,
                    TedarikciID = (int)cmbTedarikciler.SelectedValue
                });
                MessageBox.Show("Ürün Eklendi.");
                UrunListele();
            });
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleException(() =>
            {
                _urunlerService.Sil(new Urunler
                {
                    UrunID = (int)dataGridView1.CurrentRow.Cells["UrunID"].Value
                });
                MessageBox.Show("Ürün Sil");
                UrunListele();

            });
        }




        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            HandleException(() =>
            {

                _urunlerService.Guncelle(new Urunler
                {
                    UrunID = (int)txtUrunAdi.Tag,
                    Adi = txtUrunAdi.Text,
                    Fiyat = nudFiyat.Value,
                    Stok = (short)nudFiyat.Value,
                    KategoriID = (int)cmbKategoriler.SelectedValue,
                    TedarikciID = (int)cmbTedarikciler.SelectedValue
                });
                MessageBox.Show("Guncelleme Başarılı");
                UrunListele();
            });

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            if (row != null)
            {
                txtUrunAdi.Text = row.Cells["Adi"].Value.ToString();
                nudFiyat.Value = (decimal)row.Cells["Fiyat"].Value;
                nudStok.Value = (short)row.Cells["Stok"].Value;
                cmbKategoriler.SelectedValue = row.Cells["KategoriID"].Value;
                cmbTedarikciler.SelectedValue = row.Cells["TedarikciID"].Value;
                txtUrunAdi.Tag = row.Cells["UrunID"].Value;
            }

        }
    }
}
