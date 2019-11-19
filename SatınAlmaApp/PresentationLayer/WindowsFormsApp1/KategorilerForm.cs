using SatinAlma.BusinessLayer.Abstract;
using SatinAlma.BusinessLayer.DependencyResolvers.Ninject;
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
    public partial class KategorilerForm : Form
    {
        public KategorilerForm()
        {
            InitializeComponent();
            _kategorilerService = InstanceFactory.GetInstance<IKategorilerService>();
        }
        private IKategorilerService _kategorilerService;
        private void KategorilerForm_Load(object sender, EventArgs e)
        {

            HandleException(() => { KategoriListele(); });
        }



        private void KategoriListele()
        {
            dataGridView1.DataSource = _kategorilerService.Listele();
            dataGridView1.Columns["AktifMi"].Visible = dataGridView1.Columns["Urunlers"].Visible = false;
        }

        private void HandleException(Action action)
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
            HandleException(
                () =>
                {
                    _kategorilerService.Ekle(new Kategoriler
                    {
                        Adi = txtAdi.Text,
                        Aciklama = txtAciklama.Text


                    });
                    MessageBox.Show("Kategori Eklendi.");
                    KategoriListele();
                });
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleException(
                () =>
                {
                    _kategorilerService.Sil(new Kategoriler
                    {
                        KategoriID = (int)dataGridView1.CurrentRow.Cells["KategoriID"].Value,
                    });
                    MessageBox.Show("Kategori Silindi.");
                    KategoriListele();
                });
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            HandleException(() =>
            {
                _kategorilerService.Guncelle(new Kategoriler
                {
                    Adi = txtAdi.Text,
                    Aciklama = txtAciklama.Text,
                    KategoriID = (int)txtAdi.Tag
                });
                MessageBox.Show("Kategori Güncellendi.");
                KategoriListele();
            });
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txtAdi.Text = row.Cells["Adi"].Value.ToString();
            txtAciklama.Text = row.Cells["Aciklama"].Value.ToString();
            txtAdi.Tag = row.Cells["KategoriID"].Value;
        }
    }
}
