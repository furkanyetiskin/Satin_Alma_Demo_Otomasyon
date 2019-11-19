using SatinAlma.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatinAlma.BusinessLayer.Abstract
{
  public  interface IUrunSatinAlimService
    {
        List<UrunSatinAlim> Listele();
        void Ekle(UrunSatinAlim entity);
        void Guncelle(UrunSatinAlim entity);
        void Sil(UrunSatinAlim entity);
        
    }
}
