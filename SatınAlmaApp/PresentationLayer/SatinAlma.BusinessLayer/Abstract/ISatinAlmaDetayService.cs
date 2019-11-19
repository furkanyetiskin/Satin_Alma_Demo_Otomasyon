using SatinAlma.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatinAlma.BusinessLayer.Abstract
{
  public  interface ISatinAlmaDetayService
    {
        List<SatinAlmaDetay> Listele();
        void Ekle(SatinAlmaDetay entity);
        void Guncelle(SatinAlmaDetay entity);
        void Sil(SatinAlmaDetay entity);
        void EkleDetay(SatinAlmaDetay entity);
    }
}
