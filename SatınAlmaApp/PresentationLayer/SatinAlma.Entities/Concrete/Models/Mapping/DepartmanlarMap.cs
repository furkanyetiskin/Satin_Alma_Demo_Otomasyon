using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SatinAlma.Entities.Models.Mapping
{
    public class DepartmanlarMap : EntityTypeConfiguration<Departmanlar>
    {
        public DepartmanlarMap()
        {
            // Primary Key
            this.HasKey(t => t.DepartmanID);

            // Properties
            this.Property(t => t.Adi)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Departmanlar");
            this.Property(t => t.DepartmanID).HasColumnName("DepartmanID");
            this.Property(t => t.Adi).HasColumnName("Adi");
        }
    }
}
