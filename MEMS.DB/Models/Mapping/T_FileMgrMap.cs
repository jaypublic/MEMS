using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MEMS.DB.Models.Mapping
{
    public class T_FileMgrMap : EntityTypeConfiguration<T_FileMgr>
    {
        public T_FileMgrMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.filename)
                .HasMaxLength(50);

            this.Property(t => t.filecode)
                .HasMaxLength(50);

            this.Property(t => t.filepath)
                .HasMaxLength(200);

            this.Property(t => t.filetype)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_FileMgr");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.filename).HasColumnName("filename");
            this.Property(t => t.filecode).HasColumnName("filecode");
            this.Property(t => t.filepath).HasColumnName("filepath");
            this.Property(t => t.filetype).HasColumnName("filetype");
        }
    }
}
