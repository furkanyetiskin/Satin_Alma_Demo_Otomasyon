using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SatinAlma.Entities.Models.Mapping
{
    public class PersonellerMap : EntityTypeConfiguration<Personeller>
    {
        public PersonellerMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonelID);

            // Properties
            this.Property(t => t.Adi)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SoyAdi)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TCKN)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            this.Property(t => t.Gorevi)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TelNo)
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.KullaniciAdi)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Parola)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Personeller");
            this.Property(t => t.PersonelID).HasColumnName("PersonelID");
            this.Property(t => t.Adi).HasColumnName("Adi");
            this.Property(t => t.SoyAdi).HasColumnName("SoyAdi");
            this.Property(t => t.TCKN).HasColumnName("TCKN");
            this.Property(t => t.Gorevi).HasColumnName("Gorevi");
            this.Property(t => t.DepartmanID).HasColumnName("DepartmanID");
            this.Property(t => t.IseGirisTarihi).HasColumnName("IseGirisTarihi");
            this.Property(t => t.TelNo).HasColumnName("TelNo");
            this.Property(t => t.KullaniciAdi).HasColumnName("KullaniciAdi");
            this.Property(t => t.Parola).HasColumnName("Parola");
            this.Property(t => t.AlisYetkiliMi).HasColumnName("AlisYetkiliMi");
            this.Property(t => t.AktifMi).HasColumnName("AktifMi");

            // Relationships
            this.HasRequired(t => t.Departmanlar)
                .WithMany(t => t.Personellers)
                .HasForeignKey(d => d.DepartmanID);

        }
    }
}
