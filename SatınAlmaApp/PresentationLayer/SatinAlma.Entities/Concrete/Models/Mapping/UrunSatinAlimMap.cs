using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SatinAlma.Entities.Models.Mapping
{
    public class UrunSatinAlimMap : EntityTypeConfiguration<UrunSatinAlim>
    {
        public UrunSatinAlimMap()
        {
            // Primary Key
            this.HasKey(t => t.SatinAlimID);

            // Properties
            // Table & Column Mappings
            this.ToTable("UrunSatinAlim");
            this.Property(t => t.SatinAlimID).HasColumnName("SatinAlimID");
            this.Property(t => t.PersonelID).HasColumnName("PersonelID");
            this.Property(t => t.TedarikciID).HasColumnName("TedarikciID");
            this.Property(t => t.SatinAlimTarihi).HasColumnName("SatinAlimTarihi");
            this.Property(t => t.NakliyeUcreti).HasColumnName("NakliyeUcreti");
            

            // Relationships
            this.HasOptional(t => t.Personeller)
                .WithMany(t => t.UrunSatinAlims)
                .HasForeignKey(d => d.PersonelID);

            this.HasOptional(t => t.Tedarikciler)
                .WithMany(t => t.UrunSatinAlims)
                .HasForeignKey(d => d.TedarikciID);

        }
    }
}
