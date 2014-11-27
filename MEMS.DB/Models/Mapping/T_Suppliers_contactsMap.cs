using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_Suppliers_contactsMap : EntityTypeConfiguration<T_Suppliers_contacts>
    {
        public T_Suppliers_contactsMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.contactname)
                .HasMaxLength(50);

            this.Property(t => t.sex)
                .HasMaxLength(50);

            this.Property(t => t.position)
                .HasMaxLength(50);

            this.Property(t => t.cellphone)
                .HasMaxLength(50);

            this.Property(t => t.telphone)
                .HasMaxLength(50);

            this.Property(t => t.email)
                .HasMaxLength(50);

            this.Property(t => t.qq)
                .HasMaxLength(50);

            this.Property(t => t.fax)
                .HasMaxLength(50);

            this.Property(t => t.remarks)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("T_Suppliers_contacts");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.supplierid).HasColumnName("supplierid");
            this.Property(t => t.contactname).HasColumnName("contactname");
            this.Property(t => t.sex).HasColumnName("sex");
            this.Property(t => t.position).HasColumnName("position");
            this.Property(t => t.cellphone).HasColumnName("cellphone");
            this.Property(t => t.telphone).HasColumnName("telphone");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.qq).HasColumnName("qq");
            this.Property(t => t.fax).HasColumnName("fax");
            this.Property(t => t.remarks).HasColumnName("remarks");
            this.Property(t => t.createuid).HasColumnName("createuid");
            this.Property(t => t.createtime).HasColumnName("createtime");
        }
    }
}
