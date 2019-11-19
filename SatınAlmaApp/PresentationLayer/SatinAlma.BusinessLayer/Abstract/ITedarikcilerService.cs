using SatinAlma.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatinAlma.BusinessLayer.Abstract
{
 public   interface ITedarikcilerService
    {
        List<Tedarikciler> Listele();
        void Ekle(Tedarikciler entity);
        void Guncelle(Tedarikciler entity);
        void Sil(Tedarikciler entity);
    }
}
