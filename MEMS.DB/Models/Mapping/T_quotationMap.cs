using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_quotationMap : EntityTypeConfiguration<T_quotation>
    {
        public T_quotationMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.qutationno)
                .HasMaxLength(50);

            this.Property(t => t.theme)
                .HasMaxLength(50);

            this.Property(t => t.productremark)
                .HasMaxLength(200);

            this.Property(t => t.quremark)
                .HasMaxLength(200);

            this.Property(t => t.quotationtxt)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_quotation");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.qutationno).HasColumnName("qutationno");
            this.Property(t => t.theme).HasColumnName("theme");
            this.Property(t => t.totalprice).HasColumnName("totalprice");
            this.Property(t => t.customerid).HasColumnName("customerid");
            this.Property(t => t.quotationdate).HasColumnName("quotationdate");
            this.Property(t => t.productremark).HasColumnName("productremark");
            this.Property(t => t.quremark).HasColumnName("quremark");
            this.Property(t => t.quotationperson).HasColumnName("quotationperson");
            this.Property(t => t.quotationtxt).HasColumnName("quotationtxt");
        }
    }
}
