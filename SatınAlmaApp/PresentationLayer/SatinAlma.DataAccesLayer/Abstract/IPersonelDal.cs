using SatinAlma.DataAccesLayer.Concrete.EntityFramework;
using SatinAlma.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatinAlma.DataAccesLayer.Abstract
{
   public interface IPersonelDal:IEntityRepository<Personeller>
    {
      
        Personeller GirisYap(Personeller p);
    }
}
