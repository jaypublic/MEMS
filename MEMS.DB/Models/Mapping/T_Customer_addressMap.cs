using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_Customer_addressMap : EntityTypeConfiguration<T_Customer_address>
    {
        public T_Customer_addressMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.addressname)
                .HasMaxLength(50);

            this.Property(t => t.country)
                .HasMaxLength(50);

            this.Property(t => t.city)
                .HasMaxLength(50);

            this.Property(t => t.address)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Customer_address");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.customerid).HasColumnName("customerid");
            this.Property(t => t.addressname).HasColumnName("addressname");
            this.Property(t => t.country).HasColumnName("country");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.address).HasColumnName("address");
            this.Property(t => t.createuid).HasColumnName("createuid");
            this.Property(t => t.createtime).HasColumnName("createtime");
        }
    }
}
