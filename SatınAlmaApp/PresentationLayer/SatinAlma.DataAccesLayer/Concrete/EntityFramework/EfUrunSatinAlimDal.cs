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
    public class EfUrunSatinAlimDal : EfEntityRepositoryBase<UrunSatinAlim, SatinAlmaContext>, IUrunSatinAlimDal
    {
        
    }
}
