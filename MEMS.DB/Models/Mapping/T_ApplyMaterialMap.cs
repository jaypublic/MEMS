using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_ApplyMaterialMap : EntityTypeConfiguration<T_ApplyMaterial>
    {
        public T_ApplyMaterialMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.MatCode)
                .HasMaxLength(50);

            this.Property(t => t.MatDesc)
                .HasMaxLength(50);

            this.Property(t => t.MatTypeCode)
                .HasMaxLength(50);

            this.Property(t => t.MatModeCode)
                .HasMaxLength(50);

            this.Property(t => t.Unit)
                .HasMaxLength(50);

            this.Property(t => t.Id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ApplyUseNo)
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_ApplyMaterial");
            this.Property(t => t.MatCode).HasColumnName("MatCode");
            this.Property(t => t.MatDesc).HasColumnName("MatDesc");
            this.Property(t => t.MatTypeCode).HasColumnName("MatTypeCode");
            this.Property(t => t.MatModeCode).HasColumnName("MatModeCode");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ApplyUseNo).HasColumnName("ApplyUseNo");
            this.Property(t => t.ApplyQuantity).HasColumnName("ApplyQuantity");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.AvailableQuantity).HasColumnName("AvailableQuantity");
        }
    }
}
