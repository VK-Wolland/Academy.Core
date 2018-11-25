using Academy.Core.Api.DataAbstractions;
using Academy.Core.Api.DataObjects;
using Microsoft.EntityFrameworkCore;

namespace Academy.Core.Api.DataAccess.Repository
{
    public class UserRepository : BaseRepository<UserEntity>, IUserRepository
    {
        public UserRepository(AcademyDbContext dbContext)
            : base(dbContext)
        {
        }

        public override DbSet<UserEntity> Entities => DbContext.Users;
    }
}