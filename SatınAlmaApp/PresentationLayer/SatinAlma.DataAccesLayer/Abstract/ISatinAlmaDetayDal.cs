using SatinAlma.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatinAlma.DataAccesLayer.Abstract
{
   public interface ISatinAlmaDetayDal:IEntityRepository<SatinAlmaDetay>
    {
        void EkleDetay(SatinAlmaDetay entity);
    }
}
