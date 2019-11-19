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
    public class SatinAlmaDetayManager : ISatinAlmaDetayService
    {
        private ISatinAlmaDetayDal _satinAlmaDetayDal;
        public SatinAlmaDetayManager(ISatinAlmaDetayDal satinAlmaDetayDal)
        {
            _satinAlmaDetayDal = satinAlmaDetayDal;
        }
        public void Ekle(SatinAlmaDetay entity)
        {
            _satinAlmaDetayDal.Ekle(entity);
        }

        public void EkleDetay(SatinAlmaDetay entity)
        {
            _satinAlmaDetayDal.EkleDetay(entity);
        }

        public void Guncelle(SatinAlmaDetay entity)
        {
            _satinAlmaDetayDal.Guncelle(entity);
        }

        public List<SatinAlmaDetay> Listele()
        {
            return _satinAlmaDetayDal.Listele();
        }

        public void Sil(SatinAlmaDetay entity)
        {
            _satinAlmaDetayDal.Sil(entity);
        }
    }
}
