using SatinAlma.BusinessLayer.Abstract;
using SatinAlma.DataAccesLayer.Abstract;
using SatinAlma.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatinAlma.BusinessLayer.Concrete
{
    public class UrunSatinAlimManager : IUrunSatinAlimService
    {
       private IUrunSatinAlimDal _urunSatinAlimDal;
        public UrunSatinAlimManager(IUrunSatinAlimDal urunSatinAlimDal)
        {
            _urunSatinAlimDal = urunSatinAlimDal;
        }
        public void Ekle(UrunSatinAlim entity)
        {
            _urunSatinAlimDal.Ekle(entity);
        }

        public void Guncelle(UrunSatinAlim entity)
        {
            _urunSatinAlimDal.Guncelle(entity);
        }

      

        public List<UrunSatinAlim> Listele()
        {
            return _urunSatinAlimDal.Listele();
        }

        public void Sil(UrunSatinAlim entity)
        {
            _urunSatinAlimDal.Sil(entity);
        }
    }
}
