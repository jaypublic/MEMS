using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_ProductTypeMap : EntityTypeConfiguration<T_ProductType>
    {
        public T_ProductTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.typecode)
                .HasMaxLength(50);

            this.Property(t => t.typename)
                .HasMaxLength(50);

            this.Property(t => t.typedesc)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_ProductType");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.typecode).HasColumnName("typecode");
            this.Property(t => t.typename).HasColumnName("typename");
            this.Property(t => t.typedesc).HasColumnName("typedesc");
            this.Property(t => t.fid).HasColumnName("fid");
        }
    }
}
