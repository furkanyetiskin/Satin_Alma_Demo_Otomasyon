using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SatinAlma.Entities.Models.Mapping
{
    public class SatinAlmaDetayMap : EntityTypeConfiguration<SatinAlmaDetay>
    {
        public SatinAlmaDetayMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UrunID, t.SatinAlimID });

            // Properties
            this.Property(t => t.UrunID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SatinAlimID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SatinAlmaDetay");
            this.Property(t => t.UrunID).HasColumnName("UrunID");
            this.Property(t => t.SatinAlimID).HasColumnName("SatinAlimID");
           
            this.Property(t => t.DurumID).HasColumnName("DurumID");
            this.Property(t => t.AlinmaTarihi).HasColumnName("AlinmaTarihi");
            this.Property(t => t.Fiyat).HasColumnName("Fiyat");
            this.Property(t => t.Adet).HasColumnName("Adet");
            // Relationships
            this.HasRequired(t => t.SiparisDurum)
                .WithMany(t => t.SatinAlmaDetays)
                .HasForeignKey(d => d.DurumID);
            this.HasRequired(t => t.Urunler)
                .WithMany(t => t.SatinAlmaDetays)
                .HasForeignKey(d => d.UrunID);
            this.HasRequired(t => t.UrunSatinAlim)
                .WithMany(t => t.SatinAlmaDetays)
                .HasForeignKey(d => d.SatinAlimID);

        }
    }
}
