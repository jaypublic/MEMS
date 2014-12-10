using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_ProductMap : EntityTypeConfiguration<T_Product>
    {
        public T_ProductMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.procode)
                .HasMaxLength(50);

            this.Property(t => t.proname)
                .HasMaxLength(50);

            this.Property(t => t.prounit)
                .HasMaxLength(50);

            this.Property(t => t.prospecification)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Product");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.customerid).HasColumnName("customerid");
            this.Property(t => t.protype).HasColumnName("protype");
            this.Property(t => t.procode).HasColumnName("procode");
            this.Property(t => t.proname).HasColumnName("proname");
            this.Property(t => t.prounit).HasColumnName("prounit");
            this.Property(t => t.prospecification).HasColumnName("prospecification");
            this.Property(t => t.pronetweight).HasColumnName("pronetweight");
            this.Property(t => t.progrossweight).HasColumnName("progrossweight");
        }
    }
}
