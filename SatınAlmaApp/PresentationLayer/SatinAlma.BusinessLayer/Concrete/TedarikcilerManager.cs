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
    public class TedarikcilerManager : ITedarikcilerService
    {
        private ITedarikcilerDal _tedarikcilerDal;
        public TedarikcilerManager(ITedarikcilerDal tedarikcilerDal)
        {
            _tedarikcilerDal = tedarikcilerDal;
        }
        public void Ekle(Tedarikciler entity)
        {
            _tedarikcilerDal.Ekle(entity);

        }

        public void Guncelle(Tedarikciler entity)
        {
            _tedarikcilerDal.Guncelle(entity);
        }

        public List<Tedarikciler> Listele()
        {
            return _tedarikcilerDal.Listele();
        }

        public void Sil(Tedarikciler entity)
        {
            _tedarikcilerDal.Sil(entity);
        }
    }
}
