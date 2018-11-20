using System.Threading.Tasks;
using Academy.Core.Api.DataObjects;

namespace Academy.Core.Api.DataAbstractions
{
    public interface IRepository<T>
        where T : BaseEntity
    {
        int SaveChanges();

        Task<int> SaveChangesAsync();
    }
}