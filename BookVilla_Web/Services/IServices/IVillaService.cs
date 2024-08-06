using BookVilla_Web.Models.DTO;

namespace BookVilla_Web.Services.IServices
{
    public interface IVillaService
    {
        Task<T> GetAllAsync<T>(string token);
        Task<T> GetAsync<T>(int id, string token);
        Task<T> CreateAsync<T>(VillaDTOcreate dto, string token);
        Task<T> UpdateAsync<T>(VillaDTOupdate dto, string token);
        Task<T> DeleteAsync<T>(int id, string token);
    }
}
