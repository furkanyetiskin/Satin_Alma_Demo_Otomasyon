using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SatinAlma.Entities.Models.Mapping
{
    public class SiparisDurumuMap : EntityTypeConfiguration<SiparisDurumu>
    {
        public SiparisDurumuMap()
        {
            // Primary Key
            this.HasKey(t => t.DurumID);

            // Properties
            this.Property(t => t.SiparisDurum)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SiparisDurumu");
            this.Property(t => t.DurumID).HasColumnName("DurumID");
            this.Property(t => t.SiparisDurum).HasColumnName("SiparisDurum");
        }
    }
}
