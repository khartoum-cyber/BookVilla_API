using BookVilla_Web.Models.DTO;

namespace BookVilla_Web.Services.IServices
{
    public interface IVillaService
    {
        Task<T> GetAllAsync<T>();
        Task<T> GetAsync<T>(int id);
        Task<T> CreateAsync<T>(VillaDTOcreate dto);
        Task<T> UpdateAsync<T>(VillaDTOupdate dto);
        Task<T> DeleteAsync<T>(int id);
    }
}
