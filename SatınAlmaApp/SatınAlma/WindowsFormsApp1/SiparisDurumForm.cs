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
    public partial class SiparisDurumForm : Form
    {
        public SiparisDurumForm()
        {
            InitializeComponent();
            _siparisDurumService = InstanceFactory.GetInstance<ISiparisDurumuService>();
        }
        private ISiparisDurumuService _siparisDurumService;
        private void SiparisDurumForm_Load(object sender, EventArgs e)
        {
            HandlerException(() =>
            {
                DurumListele();
            });

        }

        private void DurumListele()
        {
            dataGridView1.DataSource = _siparisDurumService.Listele();
            dataGridView1.Columns["SatinAlmaDetays"].Visible = false;
            dataGridView1.Columns["SiparisDurumu1"].HeaderText = "SiparisDurumu";
        }

        private void HandlerException(Action action)
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
            HandlerException(() =>
            {
                _siparisDurumService.Ekle(new SiparisDurumu
                {
                    SiparisDurum = txtSiparisDurum.Text,

                });
                MessageBox.Show("Durum Eklendi.");
                DurumListele();
            });
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            HandlerException(() =>
            {
                _siparisDurumService.Guncelle(new SiparisDurumu
                {
                    DurumID = (int)txtSiparisDurum.Tag,
                    SiparisDurum = txtSiparisDurum.Text
                });
                MessageBox.Show("Durum Güncellendi.");
                DurumListele();
            });
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtSiparisDurum.Tag = (int)dataGridView1.CurrentRow.Cells["DurumID"].Value;
                txtSiparisDurum.Text = dataGridView1.CurrentRow.Cells["SiparisDurumu1"].Value.ToString();
            }

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandlerException(() =>
            {
                if (dataGridView1.CurrentRow != null)
                {
                    _siparisDurumService.Sil(new SiparisDurumu
                    {
                        DurumID = (int)dataGridView1.CurrentRow.Cells["DurumID"].Value

                    });
                    MessageBox.Show("Durum Silindi.");
                    DurumListele();

                }
            });
        }
    }
}
