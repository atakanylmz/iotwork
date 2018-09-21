using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace iotWork.Models.Mapping
{
    public class TypeMap : EntityTypeConfiguration<Type>
    {
        public TypeMap()
        {
            // Primary Key
            this.HasKey(t => t.typeID);

            // Properties
            this.Property(t => t.typeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.typeName)
                .IsFixedLength()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Type");
            this.Property(t => t.typeID).HasColumnName("typeID");
            this.Property(t => t.typeName).HasColumnName("typeName");
        }
    }
}
