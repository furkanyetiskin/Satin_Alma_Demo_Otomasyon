using SatinAlma.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatinAlma.BusinessLayer.Abstract
{
  public  interface IPersonelService
    {
        List<Personeller> Listele();
        void Ekle(Personeller entity);
        void Guncelle(Personeller entity);
        void Sil(Personeller entity);
        Personeller GirisYap(Personeller entity);

    }
}
