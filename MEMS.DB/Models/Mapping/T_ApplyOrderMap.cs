using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_ApplyOrderMap : EntityTypeConfiguration<T_ApplyOrder>
    {
        public T_ApplyOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.ApplyUseNo);

            // Properties
            this.Property(t => t.ApplyUseNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Dept)
                .HasMaxLength(50);

            this.Property(t => t.DeptDesc)
                .HasMaxLength(50);

            this.Property(t => t.ApplyUseDate)
                .HasMaxLength(8);

            this.Property(t => t.ApplyUser)
                .HasMaxLength(50);

            this.Property(t => t.ApplyUserDesc)
                .HasMaxLength(50);

            this.Property(t => t.SaleNo)
                .HasMaxLength(50);

            this.Property(t => t.ProductOrderNo)
                .HasMaxLength(50);

            this.Property(t => t.Applicant)
                .HasMaxLength(50);

            this.Property(t => t.ApplicantDesc)
                .HasMaxLength(50);

            this.Property(t => t.Register)
                .HasMaxLength(50);

            this.Property(t => t.RegisterDesc)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_ApplyOrder");
            this.Property(t => t.ApplyUseNo).HasColumnName("ApplyUseNo");
            this.Property(t => t.Dept).HasColumnName("Dept");
            this.Property(t => t.DeptDesc).HasColumnName("DeptDesc");
            this.Property(t => t.ApplyUseDate).HasColumnName("ApplyUseDate");
            this.Property(t => t.ApplyUseType).HasColumnName("ApplyUseType");
            this.Property(t => t.ApplyUser).HasColumnName("ApplyUser");
            this.Property(t => t.ApplyUserDesc).HasColumnName("ApplyUserDesc");
            this.Property(t => t.SaleNo).HasColumnName("SaleNo");
            this.Property(t => t.ProductOrderNo).HasColumnName("ProductOrderNo");
            this.Property(t => t.ApplyUseStatus).HasColumnName("ApplyUseStatus");
            this.Property(t => t.Applicant).HasColumnName("Applicant");
            this.Property(t => t.ApplicantDesc).HasColumnName("ApplicantDesc");
            this.Property(t => t.Register).HasColumnName("Register");
            this.Property(t => t.RegisterDesc).HasColumnName("RegisterDesc");
            this.Property(t => t.RegisterDate).HasColumnName("RegisterDate");
        }
    }
}
