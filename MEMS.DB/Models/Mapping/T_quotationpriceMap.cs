using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_quotationpriceMap : EntityTypeConfiguration<T_quotationprice>
    {
        public T_quotationpriceMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_quotationprice");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.quotationid).HasColumnName("quotationid");
            this.Property(t => t.productid).HasColumnName("productid");
            this.Property(t => t.productcount).HasColumnName("productcount");
            this.Property(t => t.modelprice).HasColumnName("modelprice");
            this.Property(t => t.quotationprice).HasColumnName("quotationprice");
            this.Property(t => t.unitprice).HasColumnName("unitprice");
        }
    }
}
