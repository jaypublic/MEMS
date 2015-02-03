using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_InvoiceMap : EntityTypeConfiguration<T_Invoice>
    {
        public T_InvoiceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InvoiceNo)
                .HasMaxLength(50);

            this.Property(t => t.PONo)
                .HasMaxLength(50);

            this.Property(t => t.Oper)
                .HasMaxLength(50);

            this.Property(t => t.OperDesc)
                .HasMaxLength(50);

            this.Property(t => t.Attachment)
                .HasMaxLength(500);

            this.Property(t => t.Remark)
                .HasMaxLength(200);

            this.Property(t => t.Register)
                .HasMaxLength(50);

            this.Property(t => t.RegisterDesc)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_Invoice");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.InvoiceNo).HasColumnName("InvoiceNo");
            this.Property(t => t.PONo).HasColumnName("PONo");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.PayDate).HasColumnName("PayDate");
            this.Property(t => t.Oper).HasColumnName("Oper");
            this.Property(t => t.OperDesc).HasColumnName("OperDesc");
            this.Property(t => t.Attachment).HasColumnName("Attachment");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.Register).HasColumnName("Register");
            this.Property(t => t.RegisterDesc).HasColumnName("RegisterDesc");
            this.Property(t => t.RegisterDate).HasColumnName("RegisterDate");
        }
    }
}
