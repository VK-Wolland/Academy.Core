using Academy.Core.Api.DataObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academy.Core.Api.DataAccess.EntityConfiguration
{
    public class UserEntityConfiguration : BaseEntityConfiguration<UserEntity>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasDefaultValueSql("NEWSEQUENTIALID()");

            builder.Property(e => e.PasswordHash).IsRequired().HasMaxLength(1024);
            builder.Property(e => e.Email).IsRequired().HasMaxLength(1024);
            builder.Property(e => e.FirstName).IsRequired().HasMaxLength(1024);
            builder.Property(e => e.LastName).HasMaxLength(1024);
            builder.Property(e => e.MiddleName).HasMaxLength(1024);
            builder.Property(e => e.DateOfBirth);
        }
    }
}