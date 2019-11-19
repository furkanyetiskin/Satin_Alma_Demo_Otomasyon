using SatinAlma.DataAccesLayer.Abstract;
using SatinAlma.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatinAlma.DataAccesLayer.Concrete.EntityFramework
{
    public class EfPersonellerDal : EfEntityRepositoryBase<Personeller, SatinAlmaContext>, IPersonelDal
    {
     
        public Personeller GirisYap(Personeller p)
        {
            SatinAlmaContext context = new SatinAlmaContext();
            var aktif = context.Database.SqlQuery<Personeller>("prc_PersonelGiris @ka={0}, @prl={1}", p.KullaniciAdi,p.Parola).ToList();

            if (aktif.Count==0)
            {
                return null;
            }
            Personeller Aktif = new Personeller();
            foreach (var item in aktif)
            {
                Aktif.PersonelID = item.PersonelID;
                Aktif.Adi = item.Adi;
                Aktif.SoyAdi = item.SoyAdi;
                Aktif.TCKN = item.TCKN;
                Aktif.DepartmanID = item.DepartmanID;
                Aktif.IseGirisTarihi = item.IseGirisTarihi;
                Aktif.TelNo = item.TelNo;
                Aktif.KullaniciAdi = item.KullaniciAdi;
                Aktif.Parola = item.Parola;
                Aktif.AlisYetkiliMi = item.AlisYetkiliMi;
                Aktif.AktifMi = item.AktifMi;
            }
            return Aktif;
        }
    }
}
