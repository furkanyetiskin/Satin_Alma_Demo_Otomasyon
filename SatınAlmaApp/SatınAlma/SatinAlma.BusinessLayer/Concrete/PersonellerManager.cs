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
    public class PersonellerManager : IPersonelService
    {
        public static Personeller Aktif;
        private IPersonelDal _personelDal;
        public PersonellerManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }
        public void Ekle(Personeller entity)
        {
            _personelDal.Ekle(entity);
        }

        public List<Personeller> Listele()
        {
            return _personelDal.Listele();
        }

        public void Guncelle(Personeller entity)
        {
            _personelDal.Guncelle(entity);
        }

        public void Sil(Personeller entity)
        {
            _personelDal.Sil(entity);
            
        }

        public Personeller GirisYap(Personeller entity)
        {
            return _personelDal.GirisYap(entity);
        }
    }
}
