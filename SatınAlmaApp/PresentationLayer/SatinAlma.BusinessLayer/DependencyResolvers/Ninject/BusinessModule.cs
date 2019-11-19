using Ninject.Modules;
using SatinAlma.BusinessLayer.Abstract;
using SatinAlma.BusinessLayer.Concrete;
using SatinAlma.DataAccesLayer.Abstract;
using SatinAlma.DataAccesLayer.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatinAlma.BusinessLayer.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUrunlerService>().To<UrunlerManager>().InSingletonScope();
            Bind<IUrunlerDal>().To<EfUrunlerDal>().InSingletonScope();

            Bind<IPersonelService>().To<PersonellerManager>().InSingletonScope();
            Bind<IPersonelDal>().To<EfPersonellerDal>().InSingletonScope();

            Bind<IDepartmanlarService>().To<DepartmanlarManager>().InSingletonScope();
            Bind<IDepartmanlarDal>().To<EfDepartmanlarDal>().InSingletonScope();

            Bind<ITedarikcilerService>().To<TedarikcilerManager>().InSingletonScope();
            Bind<ITedarikcilerDal>().To<EfTedarikcilerDal>().InSingletonScope();

            Bind<IKategorilerService>().To<KategorilerManager>().InSingletonScope();
            Bind<IKategorilerDal>().To<EfKategorilerDal>().InSingletonScope();

            Bind<ISiparisDurumuService>().To<SiparisDurumuManager>().InSingletonScope();
            Bind<ISiparisDurumDal>().To<EfSiparisDurumDal>().InSingletonScope();

            Bind<IUrunSatinAlimService>().To<UrunSatinAlimManager>().InSingletonScope();
            Bind<IUrunSatinAlimDal>().To<EfUrunSatinAlimDal>().InSingletonScope();

            Bind<ISatinAlmaDetayService>().To<SatinAlmaDetayManager>().InSingletonScope();
            Bind<ISatinAlmaDetayDal>().To<EfSatinAlmaDetay>().InSingletonScope();
            
        }
    }
}
