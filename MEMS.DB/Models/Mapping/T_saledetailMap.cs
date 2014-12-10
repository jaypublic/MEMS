using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_saledetailMap : EntityTypeConfiguration<T_saledetail>
    {
        public T_saledetailMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("T_saledetail");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.soid).HasColumnName("soid");
            this.Property(t => t.productid).HasColumnName("productid");
            this.Property(t => t.productnumber).HasColumnName("productnumber");
            this.Property(t => t.plandeliverydate).HasColumnName("plandeliverydate");
            this.Property(t => t.producttotalprice).HasColumnName("producttotalprice");
            this.Property(t => t.actualdeliverydate).HasColumnName("actualdeliverydate");
            this.Property(t => t.planreceivedate).HasColumnName("planreceivedate");
            this.Property(t => t.actrualreceivedate).HasColumnName("actrualreceivedate");
            this.Property(t => t.receivestate).HasColumnName("receivestate");
            this.Property(t => t.receiveamount).HasColumnName("receiveamount");
        }
    }
}
