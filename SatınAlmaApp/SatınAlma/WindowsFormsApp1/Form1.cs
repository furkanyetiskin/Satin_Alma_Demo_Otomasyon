using SatinAlma.BusinessLayer.Concrete;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DepartmanForm df = new DepartmanForm();
        private void departmanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (df.IsDisposed)
            {
                df = new DepartmanForm();
               
            }
            df.MdiParent = this;
            df.Show();

        }
        KategorilerForm kf = new KategorilerForm();
        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kf.IsDisposed)
            {
                kf = new KategorilerForm();
            }
            kf.MdiParent = this;
            kf.Show();
        }
        PersonelForm pf = new PersonelForm();
        private void personellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pf.IsDisposed)
            {
                pf = new PersonelForm();
            }
            pf.MdiParent = this;
            pf.Show();
        }
        TedarikciForm tf = new TedarikciForm();
        private void tedarikçilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tf.IsDisposed)
            {
                tf = new TedarikciForm();
            }
            tf.MdiParent = this;
            tf.Show();
        }
        UrunlerForm uf = new UrunlerForm();
        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uf.IsDisposed)
            {
                uf = new UrunlerForm();
            }
            uf.MdiParent = this;
            uf.Show();
        }
        SiparisDurumForm sdf = new SiparisDurumForm();
        private void siparişDetaylarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sdf.IsDisposed)
            {
                sdf = new SiparisDurumForm();
            }
            sdf.MdiParent = this;
            sdf.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblOturumAcan.Text = string.Format("Hoşgeldin ,{0}.", PersonellerManager.Aktif.Adi);
        }
        SatinAlimForm saf = new SatinAlimForm();
        private void satınAlımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saf.IsDisposed)
            {
                saf = new SatinAlimForm();

            }
            saf.MdiParent = this;
            saf.Show();
        }
        SatinAlinacaklarForm satinAlinanlarForm = new SatinAlinacaklarForm();
        private void ürünSatınAlımıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (satinAlinanlarForm.IsDisposed)
            {
                satinAlinanlarForm = new SatinAlinacaklarForm();
            }
            satinAlinanlarForm.MdiParent = this;
            satinAlinanlarForm.Show();
        }
        SatinAlinanForm satinAlinanForm = new SatinAlinanForm();
        private void satınAlmaDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (satinAlinanForm.IsDisposed)
            {
                satinAlinanForm = new SatinAlinanForm();
            }
            satinAlinanForm.MdiParent = this;
            satinAlinanForm.Show();
        }
    }
}
