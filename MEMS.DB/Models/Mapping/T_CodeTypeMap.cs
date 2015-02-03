using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_CodeTypeMap : EntityTypeConfiguration<T_CodeType>
    {
        public T_CodeTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Code)
                .HasMaxLength(50);

            this.Property(t => t.CodeDesc)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_CodeType");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.CodeDesc).HasColumnName("CodeDesc");
        }
    }
}
