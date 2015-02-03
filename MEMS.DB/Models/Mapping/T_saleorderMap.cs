using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_saleorderMap : EntityTypeConfiguration<T_saleorder>
    {
        public T_saleorderMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.saleno)
                .HasMaxLength(50);

            this.Property(t => t.receiveratio)
                .HasMaxLength(50);

            this.Property(t => t.remarks)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("T_saleorder");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.saleno).HasColumnName("saleno");
            this.Property(t => t.saledate).HasColumnName("saledate");
            this.Property(t => t.receiveperiodtype).HasColumnName("receiveperiodtype");
            this.Property(t => t.receiveperiod).HasColumnName("receiveperiod");
            this.Property(t => t.customerid).HasColumnName("customerid");
            this.Property(t => t.quotationid).HasColumnName("quotationid");
            this.Property(t => t.receivetype).HasColumnName("receivetype");
            this.Property(t => t.receivestate).HasColumnName("receivestate");
            this.Property(t => t.orderstate).HasColumnName("orderstate");
            this.Property(t => t.saletotalamount).HasColumnName("saletotalamount");
            this.Property(t => t.receiveamount).HasColumnName("receiveamount");
            this.Property(t => t.receiveratio).HasColumnName("receiveratio");
            this.Property(t => t.remarks).HasColumnName("remarks");
        }
    }
}
