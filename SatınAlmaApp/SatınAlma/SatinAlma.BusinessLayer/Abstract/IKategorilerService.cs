using SatinAlma.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatinAlma.BusinessLayer.Abstract
{
 public interface IKategorilerService
    {
        List<Kategoriler> Listele();
        void Ekle(Kategoriler entity);
        void Guncelle(Kategoriler entity);
        void Sil(Kategoriler entity);
    }
}
