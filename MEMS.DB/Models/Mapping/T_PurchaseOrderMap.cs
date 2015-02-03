using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_PurchaseOrderMap : EntityTypeConfiguration<T_PurchaseOrder>
    {
        public T_PurchaseOrderMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PONo, t.POType, t.Amount, t.ArrivalStatus, t.POStatus, t.PaymentStatus, t.StorageStatus });

            // Properties
            this.Property(t => t.PONo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ApplyDate)
                .HasMaxLength(8);

            this.Property(t => t.POType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Amount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ArrivalStatus)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Buyer)
                .HasMaxLength(50);

            this.Property(t => t.BuyerDesc)
                .HasMaxLength(50);

            this.Property(t => t.SaleNo)
                .HasMaxLength(50);

            this.Property(t => t.DemandArrivalDate)
                .HasMaxLength(8);

            this.Property(t => t.ActualArrivalDate)
                .HasMaxLength(8);

            this.Property(t => t.ArrivalRemark)
                .HasMaxLength(200);

            this.Property(t => t.POStatus)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ApplyDept)
                .HasMaxLength(50);

            this.Property(t => t.ApplyDeptDesc)
                .HasMaxLength(50);

            this.Property(t => t.Applicant)
                .HasMaxLength(50);

            this.Property(t => t.ApplicantDesc)
                .HasMaxLength(50);

            this.Property(t => t.Register)
                .HasMaxLength(50);

            this.Property(t => t.RegisterDesc)
                .HasMaxLength(50);

            this.Property(t => t.PaymentStatus)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ApprovalDate)
                .HasMaxLength(8);

            this.Property(t => t.Approval)
                .HasMaxLength(50);

            this.Property(t => t.ApprovalDesc)
                .HasMaxLength(50);

            this.Property(t => t.SendApprovalDate)
                .HasMaxLength(8);

            this.Property(t => t.ApprovalRemark)
                .HasMaxLength(200);

            this.Property(t => t.StorageStatus)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("T_PurchaseOrder");
            this.Property(t => t.PONo).HasColumnName("PONo");
            this.Property(t => t.ApplyDate).HasColumnName("ApplyDate");
            this.Property(t => t.POType).HasColumnName("POType");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.ArrivalStatus).HasColumnName("ArrivalStatus");
            this.Property(t => t.Buyer).HasColumnName("Buyer");
            this.Property(t => t.BuyerDesc).HasColumnName("BuyerDesc");
            this.Property(t => t.SaleNo).HasColumnName("SaleNo");
            this.Property(t => t.DemandArrivalDate).HasColumnName("DemandArrivalDate");
            this.Property(t => t.ActualArrivalDate).HasColumnName("ActualArrivalDate");
            this.Property(t => t.ArrivalRemark).HasColumnName("ArrivalRemark");
            this.Property(t => t.POStatus).HasColumnName("POStatus");
            this.Property(t => t.ApplyDept).HasColumnName("ApplyDept");
            this.Property(t => t.ApplyDeptDesc).HasColumnName("ApplyDeptDesc");
            this.Property(t => t.Applicant).HasColumnName("Applicant");
            this.Property(t => t.ApplicantDesc).HasColumnName("ApplicantDesc");
            this.Property(t => t.Register).HasColumnName("Register");
            this.Property(t => t.RegisterDesc).HasColumnName("RegisterDesc");
            this.Property(t => t.RegistDate).HasColumnName("RegistDate");
            this.Property(t => t.PaymentStatus).HasColumnName("PaymentStatus");
            this.Property(t => t.ApprovalDate).HasColumnName("ApprovalDate");
            this.Property(t => t.Approval).HasColumnName("Approval");
            this.Property(t => t.ApprovalDesc).HasColumnName("ApprovalDesc");
            this.Property(t => t.SendApprovalDate).HasColumnName("SendApprovalDate");
            this.Property(t => t.ApprovalRemark).HasColumnName("ApprovalRemark");
            this.Property(t => t.StorageStatus).HasColumnName("StorageStatus");
        }
    }
}
