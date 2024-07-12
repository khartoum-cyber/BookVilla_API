using BookVilla_VillaAPI.Data;
using BookVilla_VillaAPI.Models;
using BookVilla_VillaAPI.Models.DTO;
using BookVilla_VillaAPI.Repository.IRepository;

namespace BookVilla_VillaAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDBContext _db;

        public UserRepository(ApplicationDBContext db)
        {
            _db = db;
        }
        public bool IsUniqueUser(string username)
        {
            throw new NotImplementedException();
        }

        public Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO)
        {
            throw new NotImplementedException();
        }

        public Task<LocalUser> Register(RegistrationRequestDTO registrationRequestDTO)
        {
            throw new NotImplementedException();
        }
    }
}
