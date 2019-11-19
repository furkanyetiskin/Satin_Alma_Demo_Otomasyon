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
    public class SiparisDurumuManager : ISiparisDurumuService
    {
        private ISiparisDurumDal _siparisDurumuDal;
        public SiparisDurumuManager(ISiparisDurumDal siparisDurumuDal)
        {
            _siparisDurumuDal = siparisDurumuDal;
        }
        public void Ekle(SiparisDurumu entity)
        {
            _siparisDurumuDal.Ekle(entity);
        }

        public void Guncelle(SiparisDurumu entity)
        {
            _siparisDurumuDal.Guncelle(entity);
        }

        public List<SiparisDurumu> Listele()
        {
            return _siparisDurumuDal.Listele();
        }

        public void Sil(SiparisDurumu entity)
        {
             _siparisDurumuDal.Sil(entity);
        }
    }
}
