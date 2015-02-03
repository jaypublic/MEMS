using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_UnitMap : EntityTypeConfiguration<T_Unit>
    {
        public T_UnitMap()
        {
            // Primary Key
            this.HasKey(t => t.UnitCode);

            // Properties
            this.Property(t => t.UnitCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UnitDesc)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Unit");
            this.Property(t => t.UnitCode).HasColumnName("UnitCode");
            this.Property(t => t.UnitDesc).HasColumnName("UnitDesc");
        }
    }
}
