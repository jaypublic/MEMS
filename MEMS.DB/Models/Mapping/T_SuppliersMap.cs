using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_SuppliersMap : EntityTypeConfiguration<T_Suppliers>
    {
        public T_SuppliersMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.supplierno)
                .HasMaxLength(50);

            this.Property(t => t.suppliername)
                .HasMaxLength(50);

            this.Property(t => t.simplename)
                .HasMaxLength(50);

            this.Property(t => t.suppliertype)
                .HasMaxLength(50);

            this.Property(t => t.telphone)
                .HasMaxLength(50);

            this.Property(t => t.fax)
                .HasMaxLength(50);

            this.Property(t => t.email)
                .HasMaxLength(50);

            this.Property(t => t.website)
                .HasMaxLength(50);

            this.Property(t => t.postcode)
                .HasMaxLength(50);

            this.Property(t => t.country)
                .HasMaxLength(50);

            this.Property(t => t.province)
                .HasMaxLength(50);

            this.Property(t => t.city)
                .HasMaxLength(50);

            this.Property(t => t.address)
                .HasMaxLength(50);

            this.Property(t => t.bank)
                .HasMaxLength(50);

            this.Property(t => t.accountname)
                .HasMaxLength(50);

            this.Property(t => t.accountno)
                .HasMaxLength(50);

            this.Property(t => t.taxcode)
                .HasMaxLength(50);

            this.Property(t => t.legalperson)
                .HasMaxLength(50);

            this.Property(t => t.businessscope)
                .HasMaxLength(500);

            this.Property(t => t.remarks)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("T_Suppliers");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.supplierno).HasColumnName("supplierno");
            this.Property(t => t.suppliername).HasColumnName("suppliername");
            this.Property(t => t.simplename).HasColumnName("simplename");
            this.Property(t => t.suppliertype).HasColumnName("suppliertype");
            this.Property(t => t.telphone).HasColumnName("telphone");
            this.Property(t => t.fax).HasColumnName("fax");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.website).HasColumnName("website");
            this.Property(t => t.postcode).HasColumnName("postcode");
            this.Property(t => t.country).HasColumnName("country");
            this.Property(t => t.province).HasColumnName("province");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.address).HasColumnName("address");
            this.Property(t => t.bank).HasColumnName("bank");
            this.Property(t => t.accountname).HasColumnName("accountname");
            this.Property(t => t.accountno).HasColumnName("accountno");
            this.Property(t => t.taxcode).HasColumnName("taxcode");
            this.Property(t => t.legalperson).HasColumnName("legalperson");
            this.Property(t => t.businessscope).HasColumnName("businessscope");
            this.Property(t => t.remarks).HasColumnName("remarks");
            this.Property(t => t.createuid).HasColumnName("createuid");
            this.Property(t => t.createtime).HasColumnName("createtime");
        }
    }
}
