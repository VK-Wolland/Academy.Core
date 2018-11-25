using System;
using Academy.Core.Api.DataAccess.EntityConfiguration;
using Academy.Core.Api.DataObjects;
using Microsoft.EntityFrameworkCore;

namespace Academy.Core.Api.DataAccess
{
    public class AcademyDbContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        public AcademyDbContext(DbContextOptions contextOptions)
            : base(contextOptions)
        {
        }

        public AcademyDbContext()
            : base()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Academy");

            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}