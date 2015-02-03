using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_StockCodeMap : EntityTypeConfiguration<T_StockCode>
    {
        public T_StockCodeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Code)
                .HasMaxLength(50);

            this.Property(t => t.Stockdesc)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_StockCode");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Stockdesc).HasColumnName("Stockdesc");
        }
    }
}
