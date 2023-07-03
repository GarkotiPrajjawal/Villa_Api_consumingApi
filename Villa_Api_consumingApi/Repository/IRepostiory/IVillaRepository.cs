using System.Linq.Expressions;
using Villa_Api_consumingApi.Models;

namespace Villa_Api_consumingApi.Repository.IRepostiory
{
    public interface IVillaRepository : IRepository<VillaOne>
    {
        Task<VillaOne> UpdateAsync(VillaOne entity);
    }
}
