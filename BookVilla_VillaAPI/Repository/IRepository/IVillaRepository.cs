using BookVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace BookVilla_VillaAPI.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);
    }
}
