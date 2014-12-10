using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_Base_customertypeMap : EntityTypeConfiguration<T_Base_customertype>
    {
        public T_Base_customertypeMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.typename)
                .HasMaxLength(50);

            this.Property(t => t.remarks)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("T_Base_customertype");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.typename).HasColumnName("typename");
            this.Property(t => t.remarks).HasColumnName("remarks");
        }
    }
}
