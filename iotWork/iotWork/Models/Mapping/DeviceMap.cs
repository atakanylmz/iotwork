using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace iotWork.Models.Mapping
{
    public class DeviceMap : EntityTypeConfiguration<Device>
    {
        public DeviceMap()
        {
            // Primary Key
            this.HasKey(t => t.deviceID);

            // Properties
            this.Property(t => t.deviceName)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.deviceIP)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.devicePassword)
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Device");
            this.Property(t => t.deviceID).HasColumnName("deviceID");
            this.Property(t => t.deviceName).HasColumnName("deviceName");
            this.Property(t => t.typeID).HasColumnName("typeID");
            this.Property(t => t.deviceIP).HasColumnName("deviceIP");
            this.Property(t => t.userID).HasColumnName("userID");
            this.Property(t => t.devicePassword).HasColumnName("devicePassword");

            // Relationships
            this.HasOptional(t => t.Type)
                .WithMany(t => t.Devices)
                .HasForeignKey(d => d.typeID);
            

        }
    }
}
