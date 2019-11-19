using SatinAlma.BusinessLayer.Abstract;
using SatinAlma.DataAccesLayer.Abstract;
using SatinAlma.DataAccesLayer.Concrete.EntityFramework;
using SatinAlma.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatinAlma.BusinessLayer.Concrete
{
    public class UrunlerManager : IUrunlerService
    {
        private IUrunlerDal _urunlerService;
        
        public UrunlerManager(IUrunlerDal urunlerService)
        {
            _urunlerService = urunlerService;
        }

        public void Ekle(Urunler entity)
        {
            _urunlerService.Ekle(entity);
        }

        public List<Urunler> Listele()
        {

            return _urunlerService.Listele();

        }

        public void Guncelle(Urunler entity)
        {
            _urunlerService.Guncelle(entity);
        }

        public void Sil(Urunler entity)
        {
            _urunlerService.Sil(entity);
        }
    }
}
