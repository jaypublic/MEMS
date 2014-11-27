using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_CraftsPriceMap : EntityTypeConfiguration<T_CraftsPrice>
    {
        public T_CraftsPriceMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.processname)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_CraftsPrice");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.pricebasicid).HasColumnName("pricebasicid");
            this.Property(t => t.pid).HasColumnName("pid");
            this.Property(t => t.processid).HasColumnName("processid");
            this.Property(t => t.processname).HasColumnName("processname");
            this.Property(t => t.processidx).HasColumnName("processidx");
            this.Property(t => t.processprice).HasColumnName("processprice");
        }
    }
}
