using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace iotWork.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.userID);

            // Properties
            this.Property(t => t.userName)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.userPassword)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.mail)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.firstName)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.lastName)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.city)
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("User");
            this.Property(t => t.userID).HasColumnName("userID");
            this.Property(t => t.userName).HasColumnName("userName");
            this.Property(t => t.userPassword).HasColumnName("userPassword");
            this.Property(t => t.mail).HasColumnName("mail");
            this.Property(t => t.firstName).HasColumnName("firstName");
            this.Property(t => t.lastName).HasColumnName("lastName");
            this.Property(t => t.birthDay).HasColumnName("birthDay");
            this.Property(t => t.city).HasColumnName("city");
        }
    }
}
