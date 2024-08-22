using BookVilla_VillaAPI.Models;
using BookVilla_VillaAPI.Models.DTO;

namespace BookVilla_VillaAPI.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser (string username);
        Task<LoginResponseDTO> Login (LoginRequestDTO loginRequestDTO);
        Task<UserDTO> Register (RegistrationRequestDTO registrationRequestDTO);
    }
}
