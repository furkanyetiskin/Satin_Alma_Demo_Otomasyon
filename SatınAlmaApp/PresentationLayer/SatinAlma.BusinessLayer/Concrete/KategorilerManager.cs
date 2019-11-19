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
    public class KategorilerManager : IKategorilerService
    {
       private IKategorilerDal _kategorilerDal;
        public KategorilerManager(IKategorilerDal kategorilerDal)
        {
            _kategorilerDal = kategorilerDal;
        }
        public void Ekle(Kategoriler entity)
        {
            _kategorilerDal.Ekle(entity);
        }

        public void Guncelle(Kategoriler entity)
        {
            _kategorilerDal.Guncelle(entity);
        }

        public List<Kategoriler> Listele()
        {
            return _kategorilerDal.Listele();
        }

        public void Sil(Kategoriler entity)
        {
            _kategorilerDal.Sil(entity);
        }
    }
}
