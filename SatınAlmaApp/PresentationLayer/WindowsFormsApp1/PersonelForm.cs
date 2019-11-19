
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
    public partial class PersonelForm : Form
    {
        public PersonelForm()
        {
            InitializeComponent();
            _personelService = InstanceFactory.GetInstance<IPersonelService>();
            _departmanlarService = InstanceFactory.GetInstance<IDepartmanlarService>();

        }

        private IPersonelService _personelService;
        private IDepartmanlarService _departmanlarService;
        private SatinAlmaContext context;

        private void PersonelForm_Load(object sender, EventArgs e)
        {
            DepartmanListele();
            PersonelListele();
        }

        private void PersonelListele()
        {
            if (context == null)
            {
                context = new SatinAlmaContext();
            }

            dataGridView1.DataSource = _personelService.Listele().Join(context.Departmanlars, p => p.DepartmanID, d => d.DepartmanID, (per, dep) => new
            {
                per.PersonelID,
                per.Adi,
                per.SoyAdi,
                per.TCKN,
                per.Gorevi,
                dep.DepartmanID,
                DepartmanAdı = dep.Adi,
                per.IseGirisTarihi,
                per.TelNo,
                per.KullaniciAdi,
                per.Parola,
                per.AlisYetkiliMi
            }).ToList();
            dataGridView1.Columns["DepartmanID"].Visible = false;
        }

        private void DepartmanListele()
        {
            cmbDepartman.DataSource = _departmanlarService.Listele();
            cmbDepartman.DisplayMember = "Adi";
            cmbDepartman.ValueMember = "DepartmanID";
        }


        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            try
            {
                _personelService.Ekle(new Personeller
                {
                    Adi = txtAdi.Text,
                    SoyAdi = txtSoyAdi.Text,
                    TCKN = mskdTCKN.Text,
                    Gorevi = txtGorev.Text,
                    DepartmanID = (int)cmbDepartman.SelectedValue,
                    IseGirisTarihi = dtpIseGiris.Value,
                    TelNo = mskdTelNo.Text,
                    KullaniciAdi = txtKullaniciAdi.Text,
                    Parola = txtParola.Text,
                    AlisYetkiliMi = checkAlisYetkisi.Checked ? true : false
                });
                MessageBox.Show("Personel Eklendi.");
                PersonelListele();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }

        private void silToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                try
                {
                    _personelService.Sil(new Personeller
                    {
                        PersonelID = (int)dataGridView1.CurrentRow.Cells["PersonelID"].Value
                    });
                    MessageBox.Show("Personel Silinmiştir.");
                    PersonelListele();
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //try
            //{
                _personelService.Guncelle(new Personeller
                {
                    PersonelID = (int)txtAdi.Tag,
                    Adi = txtAdi.Text,
                    SoyAdi = txtSoyAdi.Text,
                    TCKN = mskdTCKN.Text,
                    Gorevi = txtGorev.Text,
                    DepartmanID = (int)cmbDepartman.SelectedValue,
                    IseGirisTarihi = dtpIseGiris.Value,
                    TelNo = mskdTelNo.Text,
                    KullaniciAdi = txtKullaniciAdi.Text,
                    Parola = txtParola.Text,
                    AlisYetkiliMi = checkAlisYetkisi.Checked
                });
                MessageBox.Show("Güncelleme Başarılı.");
                PersonelListele();
            //}
            //catch (Exception exception)
            //{

            //    MessageBox.Show(exception.Message);
            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            if (dataGridView1.CurrentRow != null)
            { 
                txtAdi.Text = Convert.ToString(row.Cells["Adi"].Value);
                txtSoyAdi.Text = Convert.ToString(row.Cells["SoyAdi"].Value);
                mskdTCKN.Text = Convert.ToString(row.Cells["TCKN"].Value);
                txtGorev.Text = row.Cells["Gorevi"].Value.ToString();
                cmbDepartman.SelectedValue = row.Cells["DepartmanID"].Value;
                dtpIseGiris.Value = (DateTime)row.Cells["IseGirisTarihi"].Value;
                mskdTelNo.Text = Convert.ToString(row.Cells["TelNo"].Value);
                txtKullaniciAdi.Text = row.Cells["KullaniciAdi"].Value.ToString();
                txtParola.Text = row.Cells["Parola"].Value.ToString();
                checkAlisYetkisi.Checked = (bool)row.Cells["AlisYetkiliMi"].Value ? true : false;
                txtAdi.Tag = row.Cells["PersonelID"].Value;
            }
        }
    }
}
