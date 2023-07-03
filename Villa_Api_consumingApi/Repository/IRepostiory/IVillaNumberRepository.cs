using Villa_Api_consumingApi.Models;

namespace Villa_Api_consumingApi.Repository.IRepostiory
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}
