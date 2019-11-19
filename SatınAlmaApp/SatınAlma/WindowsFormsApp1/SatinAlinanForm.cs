using SatinAlma.BusinessLayer.Abstract;
using SatinAlma.BusinessLayer.DependencyResolvers.Ninject;
using SatinAlma.DataAccesLayer.Concrete.EntityFramework;
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
    public partial class SatinAlinanForm : Form
    {
        public SatinAlinanForm()
        {
            InitializeComponent();
            _satinAlmaDetayService = InstanceFactory.GetInstance<ISatinAlmaDetayService>();
        }
        private ISatinAlmaDetayService _satinAlmaDetayService;
  
        private void SatinAlinanForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _satinAlmaDetayService.Listele().Select(x => new
            {
                x.SatinAlimID,
                x.DurumID,
                x.UrunID,
                x.Fiyat,
                x.Adet,
                x.AlinmaTarihi
                
            }).ToList();
        }
    }
}
