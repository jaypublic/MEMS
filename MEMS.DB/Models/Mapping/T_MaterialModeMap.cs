using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_MaterialModeMap : EntityTypeConfiguration<T_MaterialMode>
    {
        public T_MaterialModeMap()
        {
            // Primary Key
            this.HasKey(t => t.MaterialModeCode);

            // Properties
            this.Property(t => t.MaterialModeCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MaterialModeDesc)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_MaterialMode");
            this.Property(t => t.MaterialModeCode).HasColumnName("MaterialModeCode");
            this.Property(t => t.MaterialModeDesc).HasColumnName("MaterialModeDesc");
        }
    }
}
