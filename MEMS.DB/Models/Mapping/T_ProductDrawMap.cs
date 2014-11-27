using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_ProductDrawMap : EntityTypeConfiguration<T_ProductDraw>
    {
        public T_ProductDrawMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.drawingno)
                .HasMaxLength(50);

            this.Property(t => t.filepath)
                .HasMaxLength(200);

            this.Property(t => t.remark)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("T_ProductDraw");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.pid).HasColumnName("pid");
            this.Property(t => t.drawingno).HasColumnName("drawingno");
            this.Property(t => t.filepath).HasColumnName("filepath");
            this.Property(t => t.remark).HasColumnName("remark");
            this.Property(t => t.isdelete).HasColumnName("isdelete");
        }
    }
}
