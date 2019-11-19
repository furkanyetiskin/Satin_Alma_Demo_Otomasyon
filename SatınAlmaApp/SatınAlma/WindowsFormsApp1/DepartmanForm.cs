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
    public partial class DepartmanForm : Form
    {
        public DepartmanForm()
        {
            InitializeComponent();
            _departmanlarService = InstanceFactory.GetInstance<IDepartmanlarService>();
        }

        private IDepartmanlarService _departmanlarService;
        private void Departmanlar_Load(object sender, EventArgs e)
        {
            SatinAlmaContext context = new SatinAlmaContext();
            //var contex = context.Database.SqlQuery<Urunler>("Select * From Urunler");
            //dgwDepartmanlar.DataSource = contex.ToList();
          
            DepartmanListele();
        }

        private void DepartmanListele()
        {
            dgwDepartmanlar.DataSource = _departmanlarService.Listele();
            dgwDepartmanlar.Columns["Personellers"].Visible = false;
        }

        private void txtDepartmanEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _departmanlarService.Ekle(new Departmanlar
                {
                    Adi = txtDepartmanAdi.Text
                });
                MessageBox.Show("Departman Eklendi.");
                DepartmanListele();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }


        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgwDepartmanlar.CurrentRow != null)
            {
                try
                {
                    _departmanlarService.Sil(new Departmanlar
                    {
                        DepartmanID = (int)dgwDepartmanlar.CurrentRow.Cells["DepartmanID"].Value
                    });
                    MessageBox.Show("Departman Silindi.");
                    DepartmanListele();
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }
            }

        }

        private void dgwDepartmanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgwDepartmanlar.CurrentRow;
            if (dgwDepartmanlar.CurrentRow != null)
            {
                txtDepartmanAdi.Text = Convert.ToString(row.Cells["Adi"].Value);
                txtDepartmanAdi.Tag = row.Cells["DepartmanID"].Value;
            }


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                _departmanlarService.Guncelle(new Departmanlar
                {
                    DepartmanID = (int)txtDepartmanAdi.Tag,
                    Adi = txtDepartmanAdi.Text
                });
                MessageBox.Show("Departman Güncellendi.");
                DepartmanListele();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }
    }
}
