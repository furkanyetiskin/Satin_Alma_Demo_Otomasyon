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
    public class DepartmanlarManager : IDepartmanlarService
    {
        private IDepartmanlarDal _departmanlarDal;
        public DepartmanlarManager(IDepartmanlarDal departmanlarDal)
        {
            _departmanlarDal = departmanlarDal;
        }
        public void Ekle(Departmanlar entity)
        {
            _departmanlarDal.Ekle(entity);
        }

        public void Guncelle(Departmanlar entity)
        {
            _departmanlarDal.Guncelle(entity);
        }

        public List<Departmanlar> Listele()
        {
            return _departmanlarDal.Listele();
        }

        public void Sil(Departmanlar entity)
        {
            _departmanlarDal.Sil(entity);
        }
    }
}
