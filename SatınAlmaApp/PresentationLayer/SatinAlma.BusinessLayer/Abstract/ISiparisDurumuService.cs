using SatinAlma.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatinAlma.BusinessLayer.Abstract
{
 public   interface ISiparisDurumuService
    {
        List<SiparisDurumu> Listele();
        void Ekle(SiparisDurumu entity);
        void Guncelle(SiparisDurumu entity);
        void Sil(SiparisDurumu entity);
    }
}
