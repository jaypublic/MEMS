using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_ProductbasicPriceMap : EntityTypeConfiguration<T_ProductbasicPrice>
    {
        public T_ProductbasicPriceMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.version)
                .HasMaxLength(50);

            this.Property(t => t.returnpricedesc)
                .HasMaxLength(50);

            this.Property(t => t.materialpricedesc)
                .HasMaxLength(50);

            this.Property(t => t.mgrpricedesc)
                .HasMaxLength(50);

            this.Property(t => t.otherpricedesc)
                .HasMaxLength(50);

            this.Property(t => t.pricebasicremark)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_ProductbasicPrice");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.productid).HasColumnName("productid");
            this.Property(t => t.version).HasColumnName("version");
            this.Property(t => t.returnmatprice).HasColumnName("returnmatprice");
            this.Property(t => t.returnpricedesc).HasColumnName("returnpricedesc");
            this.Property(t => t.materialprice).HasColumnName("materialprice");
            this.Property(t => t.materialpricedesc).HasColumnName("materialpricedesc");
            this.Property(t => t.manageprice).HasColumnName("manageprice");
            this.Property(t => t.mgrpricedesc).HasColumnName("mgrpricedesc");
            this.Property(t => t.otherprice).HasColumnName("otherprice");
            this.Property(t => t.otherpricedesc).HasColumnName("otherpricedesc");
            this.Property(t => t.totalprice).HasColumnName("totalprice");
            this.Property(t => t.pricebasicremark).HasColumnName("pricebasicremark");
        }
    }
}
