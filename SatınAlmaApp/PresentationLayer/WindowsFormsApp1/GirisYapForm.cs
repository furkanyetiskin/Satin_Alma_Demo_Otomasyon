using SatinAlma.BusinessLayer.Abstract;
using SatinAlma.BusinessLayer.Concrete;
using SatinAlma.BusinessLayer.DependencyResolvers.Ninject;
using SatinAlma.DataAccesLayer.Abstract;
using SatinAlma.DataAccesLayer.Concrete.EntityFramework;
using SatinAlma.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GirisYapForm : Form
    {
        public GirisYapForm()
        {
            InitializeComponent();
            _personelService = InstanceFactory.GetInstance<IPersonelService>();
        }
        SatinAlmaContext context = new SatinAlmaContext();
        private IPersonelService _personelService;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            Personeller p = new Personeller();
            p.KullaniciAdi = txtKullaniciAdi.Text;
            p.Parola = txtParola.Text;
            Personeller AktifKullanici = _personelService.GirisYap(p);
            if (AktifKullanici == null)
            {
                MessageBox.Show("Kullanıcı Adı veya Parola Hatalı.");

            }
            else
            {
                PersonellerManager.Aktif = AktifKullanici;
                Form1 form1 = new Form1();
                this.Hide();
                form1.ShowDialog();
            }
        }
    }
}

//var aktif = context.Database.SqlQuery<Personeller>("prc_PersonelGiris @ka={0}, @prl={1}", txtKullaniciAdi.Text, txtParola.Text).ToList();

//            try
//            {

//                foreach (var item in aktif)
//                {

//                    if (txtKullaniciAdi.Text == item.KullaniciAdi && txtParola.Text == item.Parola)
//                    {
//                        Personeller p = new Personeller();
//p.Adi = item.Adi;
//                        Form1 form1 = new Form1();
//form1.Show();
//                        MessageBox.Show(string.Format("Oturum açan kişi : {0}", p.Adi));
//                        EfPersonellerDal.Aktif = p;
//                        this.Hide();
//                    }


//                }

//                if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtParola.Text))
//                {
//                    MessageBox.Show("Kullanıcı Adı Veya Parola Boş Bırakılamaz.");
//                }
//                else if (aktif.Count <= 0)
//                {
//                    MessageBox.Show("Kullanıcı Adı Veya Parola Hatalı.");
//                }


//            }
//            catch (Exception exception)
//            {

//                MessageBox.Show(exception.Message);
//            }
