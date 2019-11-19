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
    public partial class SatinAlinacaklarForm : Form
    {
        public SatinAlinacaklarForm()
        {
            InitializeComponent();
            _urunSatinAlimService = InstanceFactory.GetInstance<IUrunSatinAlimService>();
            _siparisDurumuService = InstanceFactory.GetInstance<ISiparisDurumuService>();
            _satinAlmaDetayService = InstanceFactory.GetInstance<ISatinAlmaDetayService>();
        }
        private IUrunSatinAlimService _urunSatinAlimService;
        private ISiparisDurumuService _siparisDurumuService;
        private ISatinAlmaDetayService _satinAlmaDetayService;
        private SatinAlmaContext context;
        private void SatinAlinanlarForm_Load(object sender, EventArgs e)
        {
            if (context==null)
            {
                context = new SatinAlmaContext();
            }
            dataGridView1.DataSource = _urunSatinAlimService.Listele().Join(context.Tedarikcilers, u => u.TedarikciID, t => t.TedarikciID, (u, ted) => new
            {
                u,
                ted
            }).Join(context.Personellers, u => u.u.PersonelID, p => p.PersonelID, (u, p) => new
            {
                u,
                p
            }).Select(x => new
            {
                x.u.u.SatinAlimID,
                PersonelinAdı = x.p.Adi + " " + x.p.SoyAdi,
                ŞirketAdı = x.u.ted.SirketAdi,
                Tarih = x.u.u.SatinAlimTarihi,
                Maliyet = x.u.u.NakliyeUcreti
            }).ToList();

         
           
        }

       
    }
}
