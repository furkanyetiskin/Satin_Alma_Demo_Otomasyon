using SatinAlma.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SatinAlma.DataAccesLayer.Abstract
{
  public  interface IEntityRepository<T> where T:class , IEntity,new()
    {
        List<T> Listele(Expression<Func<T, bool>> filter=null);
        void Ekle(T entity);
        void Guncelle(T entity);
        void Sil(T entity);
    }
}
