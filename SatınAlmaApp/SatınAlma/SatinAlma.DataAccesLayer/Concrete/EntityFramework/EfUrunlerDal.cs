using SatinAlma.DataAccesLayer.Abstract;
using SatinAlma.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatinAlma.DataAccesLayer.Concrete.EntityFramework
{
  public  class EfUrunlerDal:EfEntityRepositoryBase<Urunler,SatinAlmaContext>,IUrunlerDal
    {

    }
}
