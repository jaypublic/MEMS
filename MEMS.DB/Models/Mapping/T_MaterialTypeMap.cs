using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_MaterialTypeMap : EntityTypeConfiguration<T_MaterialType>
    {
        public T_MaterialTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.MaterialTypeCode);

            // Properties
            this.Property(t => t.MaterialTypeCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MaterialTypeDesc)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_MaterialType");
            this.Property(t => t.MaterialTypeCode).HasColumnName("MaterialTypeCode");
            this.Property(t => t.MaterialTypeDesc).HasColumnName("MaterialTypeDesc");
        }
    }
}
