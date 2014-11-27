using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_CraftsMap : EntityTypeConfiguration<T_Crafts>
    {
        public T_CraftsMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.processname)
                .HasMaxLength(50);

            this.Property(t => t.remarks)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_Crafts");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.pid).HasColumnName("pid");
            this.Property(t => t.processindex).HasColumnName("processindex");
            this.Property(t => t.processname).HasColumnName("processname");
            this.Property(t => t.remarks).HasColumnName("remarks");
        }
    }
}
