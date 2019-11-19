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
    public partial class TedarikciForm : Form
    {
        public TedarikciForm()
        {
            InitializeComponent();
            _tedarikcilerService = InstanceFactory.GetInstance<ITedarikcilerService>();
        }
        private ITedarikcilerService _tedarikcilerService;
        private void TedarikciForm_Load(object sender, EventArgs e)
        {
            TedarikciListele();
        }

        private void TedarikciListele()
        {
            dataGridView1.DataSource = _tedarikcilerService.Listele();
            dataGridView1.Columns[5].Visible = dataGridView1.Columns[6].Visible = dataGridView1.Columns[7].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _tedarikcilerService.Ekle(new Tedarikciler
                {

                    SirketAdi = txtSirketAdi.Text,
                    Adres = txtAdres.Text,
                    Sehir = txtSehir.Text,
                    TelNo = mskdTelNo.Text
                });
                MessageBox.Show("Tedarikçi Eklendi.");
                TedarikciListele();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
           
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _tedarikcilerService.Sil(new Tedarikciler
                {
                    TedarikciID = (int)dataGridView1.CurrentRow.Cells["TedarikciID"].Value
                });
                MessageBox.Show("Tedarikci Silindi");
                TedarikciListele();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                _tedarikcilerService.Guncelle(new Tedarikciler
                {
                    TedarikciID = (int)txtSirketAdi.Tag,
                    SirketAdi = txtSirketAdi.Text,
                    Adres = txtAdres.Text,
                    Sehir = txtSehir.Text,
                    TelNo = mskdTelNo.Text

                });
                MessageBox.Show("Guncelleme Başarılı.");
                TedarikciListele();
                   
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            if (dataGridView1.CurrentRow!=null)
            {
                txtSirketAdi.Text = row.Cells["SirketAdi"].Value.ToString();
                txtSirketAdi.Tag = row.Cells["TedarikciID"].Value;
                txtSehir.Text = row.Cells["Sehir"].Value.ToString();
                txtAdres.Text = row.Cells["Adres"].Value.ToString();
                mskdTelNo.Text = row.Cells["TelNo"].Value.ToString();
                    
            }
        }
    }
}
