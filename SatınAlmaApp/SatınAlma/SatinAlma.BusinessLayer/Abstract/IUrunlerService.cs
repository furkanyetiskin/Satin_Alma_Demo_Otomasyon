using SatinAlma.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatinAlma.BusinessLayer.Abstract
{
  public  interface IUrunlerService
    {
        List<Urunler> Listele();
        void Ekle(Urunler entity);
        void Guncelle(Urunler entity);
        void Sil(Urunler entity);
    }
}
