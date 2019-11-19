using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SatinAlma.Entities.Models.Mapping
{
    public class TedarikcilerMap : EntityTypeConfiguration<Tedarikciler>
    {
        public TedarikcilerMap()
        {
            // Primary Key
            this.HasKey(t => t.TedarikciID);

            // Properties
            this.Property(t => t.SirketAdi)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Adres)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Sehir)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TelNo)
                .IsRequired()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("Tedarikciler");
            this.Property(t => t.TedarikciID).HasColumnName("TedarikciID");
            this.Property(t => t.SirketAdi).HasColumnName("SirketAdi");
            this.Property(t => t.Adres).HasColumnName("Adres");
            this.Property(t => t.Sehir).HasColumnName("Sehir");
            this.Property(t => t.TelNo).HasColumnName("TelNo");
            this.Property(t => t.AktifMi).HasColumnName("AktifMi");
        }
    }
}
