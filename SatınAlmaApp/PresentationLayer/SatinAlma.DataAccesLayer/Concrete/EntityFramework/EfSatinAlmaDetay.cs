using SatinAlma.DataAccesLayer.Abstract;
using SatinAlma.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatinAlma.DataAccesLayer.Concrete.EntityFramework
{
    public class EfSatinAlmaDetay : EfEntityRepositoryBase<SatinAlmaDetay, SatinAlmaContext>, ISatinAlmaDetayDal
    {
        public void EkleDetay(SatinAlmaDetay entity)
        {
            using (SatinAlmaContext context = new SatinAlmaContext())
            {
                context.SatinAlmaDetays.Add(entity);
                context.SaveChanges();
            }
        }

    }
}
