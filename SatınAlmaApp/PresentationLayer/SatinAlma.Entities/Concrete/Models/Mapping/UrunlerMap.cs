using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SatinAlma.Entities.Models.Mapping
{
    public class UrunlerMap : EntityTypeConfiguration<Urunler>
    {
        public UrunlerMap()
        {
            // Primary Key
            this.HasKey(t => t.UrunID);

            // Properties
            this.Property(t => t.Adi)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Urunler");
            this.Property(t => t.UrunID).HasColumnName("UrunID");
            this.Property(t => t.Adi).HasColumnName("Adi");
            this.Property(t => t.Fiyat).HasColumnName("Fiyat");
            this.Property(t => t.Stok).HasColumnName("Stok");
            this.Property(t => t.TedarikciID).HasColumnName("TedarikciID");
            this.Property(t => t.KategoriID).HasColumnName("KategoriID");
            this.Property(t => t.AktifMi).HasColumnName("AktifMi");

            // Relationships
            this.HasOptional(t => t.Kategoriler)
                .WithMany(t => t.Urunlers)
                .HasForeignKey(d => d.KategoriID);
            this.HasOptional(t => t.Tedarikciler)
                .WithMany(t => t.Urunlers)
                .HasForeignKey(d => d.TedarikciID);

        }
    }
}
