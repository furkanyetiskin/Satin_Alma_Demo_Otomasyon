using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SatinAlma.Entities.Models;
using SatinAlma.Entities.Models.Mapping;

namespace SatinAlma.DataAccesLayer.Concrete.EntityFramework
{
    public partial class SatinAlmaContext : DbContext
    {
        static SatinAlmaContext()
        {
            Database.SetInitializer<SatinAlmaContext>(null);
        }

        public SatinAlmaContext()
            : base("Name=SatinAlmaContext")
        {
        }

        public DbSet<Departmanlar> Departmanlars { get; set; }
        public DbSet<Kategoriler> Kategorilers { get; set; }
        public DbSet<Personeller> Personellers { get; set; }
        public DbSet<SatinAlmaDetay> SatinAlmaDetays { get; set; }
        public DbSet<SiparisDurumu> SiparisDurumus { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Tedarikciler> Tedarikcilers { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<UrunSatinAlim> UrunSatinAlims { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DepartmanlarMap());
            modelBuilder.Configurations.Add(new KategorilerMap());
            modelBuilder.Configurations.Add(new PersonellerMap());
            modelBuilder.Configurations.Add(new SatinAlmaDetayMap());
            modelBuilder.Configurations.Add(new SiparisDurumuMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TedarikcilerMap());
            modelBuilder.Configurations.Add(new UrunlerMap());
            modelBuilder.Configurations.Add(new UrunSatinAlimMap());
          
        
        }
    }
}
