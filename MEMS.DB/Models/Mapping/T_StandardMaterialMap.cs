using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_StandardMaterialMap : EntityTypeConfiguration<T_StandardMaterial>
    {
        public T_StandardMaterialMap()
        {
            // Primary Key
            this.HasKey(t => t.MatCode);

            // Properties
            this.Property(t => t.MatCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MatDesc)
                .HasMaxLength(50);

            this.Property(t => t.MatTypeCode)
                .HasMaxLength(50);

            this.Property(t => t.MatModeCode)
                .HasMaxLength(50);

            this.Property(t => t.Unit)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_StandardMaterial");
            this.Property(t => t.MatCode).HasColumnName("MatCode");
            this.Property(t => t.MatDesc).HasColumnName("MatDesc");
            this.Property(t => t.MatTypeCode).HasColumnName("MatTypeCode");
            this.Property(t => t.MatModeCode).HasColumnName("MatModeCode");
            this.Property(t => t.Unit).HasColumnName("Unit");
        }
    }
}
