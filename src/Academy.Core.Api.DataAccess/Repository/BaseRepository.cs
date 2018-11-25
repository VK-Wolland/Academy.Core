using Academy.Core.Api.DataAbstractions;
using Academy.Core.Api.DataObjects;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Academy.Core.Api.DataAccess.Repository
{
    public abstract class BaseRepository<T> : IRepository<T>
        where T : BaseEntity
    {
        public abstract DbSet<T> Entities { get; }

        public T Create(T entity)
        {
            Entities.Add(entity);
            return entity;
        }

        public void Delete(T entity)
        {
            Entities.Remove(entity);
        }

        public T Get(object id)
        {
            return Entities.Find(id);
        }

        public async Task<T> GetAsync(object id)
        {
            return await Entities.FindAsync(id);
        }

        public int SaveChanges()
        {
            return DbContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await DbContext.SaveChangesAsync();
        }

        public T Update(T entity)
        {
            if (Entities.Local.All(e => e.Equals(entity) == false))
                Entities.Attach(entity);

            return entity;
        }

        protected readonly AcademyDbContext DbContext;

        protected BaseRepository(AcademyDbContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}