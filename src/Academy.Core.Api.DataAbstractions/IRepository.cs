using Academy.Core.Api.DataObjects;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Academy.Core.Api.DataAbstractions
{
    public interface IRepository<T>
        where T : BaseEntity
    {
        DbSet<T> Entities { get; }

        int SaveChanges();

        Task<int> SaveChangesAsync();

        T Create(T entity);

        T Update(T entity);

        T Get(object id);

        Task<T> GetAsync(object id);

        void Delete(T entity);
    }
}