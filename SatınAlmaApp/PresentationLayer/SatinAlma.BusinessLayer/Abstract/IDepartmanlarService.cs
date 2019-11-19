using SatinAlma.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatinAlma.BusinessLayer.Abstract
{
   public interface IDepartmanlarService
    {
        List<Departmanlar> Listele();
        void Guncelle(Departmanlar entity);
        void Ekle(Departmanlar entity);
        void Sil(Departmanlar entity);
    }
}
