using BookVilla_Web.Models.DTO;

namespace BookVilla_Web.Services.IServices
{
    public interface IVillaNumberService
    {
        Task<T> GetAllAsync<T>();
        Task<T> GetAsync<T>(int id);
        Task<T> CreateAsync<T>(VillaNumberDTOcreate dto);
        Task<T> UpdateAsync<T>(VillaNumberDTOupdate dto);
        Task<T> DeleteAsync<T>(int id);
    }
}
