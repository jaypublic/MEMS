using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_PurchaseMaterialMap : EntityTypeConfiguration<T_PurchaseMaterial>
    {
        public T_PurchaseMaterialMap()
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

            this.Property(t => t.PONo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_PurchaseMaterial");
            this.Property(t => t.MatCode).HasColumnName("MatCode");
            this.Property(t => t.MatDesc).HasColumnName("MatDesc");
            this.Property(t => t.MatTypeCode).HasColumnName("MatTypeCode");
            this.Property(t => t.MatModeCode).HasColumnName("MatModeCode");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PONo).HasColumnName("PONo");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
        }
    }
}
