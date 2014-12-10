using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_Base_professionMap : EntityTypeConfiguration<T_Base_profession>
    {
        public T_Base_professionMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.professionname)
                .HasMaxLength(50);

            this.Property(t => t.remarks)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("T_Base_profession");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.professionname).HasColumnName("professionname");
            this.Property(t => t.remarks).HasColumnName("remarks");
        }
    }
}
