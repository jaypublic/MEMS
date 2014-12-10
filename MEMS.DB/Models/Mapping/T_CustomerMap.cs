using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_CustomerMap : EntityTypeConfiguration<T_Customer>
    {
        public T_CustomerMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.customerno)
                .HasMaxLength(50);

            this.Property(t => t.customername)
                .HasMaxLength(50);

            this.Property(t => t.simplename)
                .HasMaxLength(50);

            this.Property(t => t.country)
                .HasMaxLength(50);

            this.Property(t => t.province)
                .HasMaxLength(50);

            this.Property(t => t.city)
                .HasMaxLength(50);

            this.Property(t => t.companyaddress)
                .HasMaxLength(100);

            this.Property(t => t.phone)
                .HasMaxLength(50);

            this.Property(t => t.fax)
                .HasMaxLength(50);

            this.Property(t => t.email)
                .HasMaxLength(50);

            this.Property(t => t.website)
                .HasMaxLength(50);

            this.Property(t => t.postcode)
                .HasMaxLength(50);

            this.Property(t => t.source)
                .HasMaxLength(50);

            this.Property(t => t.customertype)
                .HasMaxLength(50);

            this.Property(t => t.profession)
                .HasMaxLength(50);

            this.Property(t => t.companytype)
                .HasMaxLength(50);

            this.Property(t => t.productinfo)
                .HasMaxLength(500);

            this.Property(t => t.customerdesc)
                .HasMaxLength(500);

            this.Property(t => t.remarks)
                .HasMaxLength(500);

            this.Property(t => t.bank)
                .HasMaxLength(50);

            this.Property(t => t.accountname)
                .HasMaxLength(50);

            this.Property(t => t.accountno)
                .HasMaxLength(50);

            this.Property(t => t.taxcode)
                .HasMaxLength(50);

            this.Property(t => t.invoiceaddress)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Customer");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.customerno).HasColumnName("customerno");
            this.Property(t => t.customername).HasColumnName("customername");
            this.Property(t => t.simplename).HasColumnName("simplename");
            this.Property(t => t.country).HasColumnName("country");
            this.Property(t => t.province).HasColumnName("province");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.companyaddress).HasColumnName("companyaddress");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.fax).HasColumnName("fax");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.website).HasColumnName("website");
            this.Property(t => t.postcode).HasColumnName("postcode");
            this.Property(t => t.source).HasColumnName("source");
            this.Property(t => t.customertype).HasColumnName("customertype");
            this.Property(t => t.profession).HasColumnName("profession");
            this.Property(t => t.companytype).HasColumnName("companytype");
            this.Property(t => t.productinfo).HasColumnName("productinfo");
            this.Property(t => t.customerdesc).HasColumnName("customerdesc");
            this.Property(t => t.remarks).HasColumnName("remarks");
            this.Property(t => t.bank).HasColumnName("bank");
            this.Property(t => t.accountname).HasColumnName("accountname");
            this.Property(t => t.accountno).HasColumnName("accountno");
            this.Property(t => t.taxcode).HasColumnName("taxcode");
            this.Property(t => t.invoiceaddress).HasColumnName("invoiceaddress");
            this.Property(t => t.createuid).HasColumnName("createuid");
            this.Property(t => t.createtime).HasColumnName("createtime");
        }
    }
}
