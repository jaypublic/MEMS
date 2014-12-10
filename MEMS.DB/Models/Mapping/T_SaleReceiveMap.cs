using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_SaleReceiveMap : EntityTypeConfiguration<T_SaleReceive>
    {
        public T_SaleReceiveMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.invoicecode)
                .HasMaxLength(50);

            this.Property(t => t.remarks)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("T_SaleReceive");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.soid).HasColumnName("soid");
            this.Property(t => t.revamount).HasColumnName("revamount");
            this.Property(t => t.revdate).HasColumnName("revdate");
            this.Property(t => t.revmanid).HasColumnName("revmanid");
            this.Property(t => t.invoicecode).HasColumnName("invoicecode");
            this.Property(t => t.remarks).HasColumnName("remarks");
        }
    }
}
