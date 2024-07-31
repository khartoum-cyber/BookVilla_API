using BookVilla_VillaAPI.Data;
using BookVilla_VillaAPI.Models;
using BookVilla_VillaAPI.Models.DTO;
using BookVilla_VillaAPI.Repository.IRepository;

namespace BookVilla_VillaAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDBContext _db;
        private string secretKey;

        public UserRepository(ApplicationDBContext db, IConfiguration configuration)
        {
            _db = db;
            secretKey = configuration.GetValue<string>("ApiSettings:Secret");
        }
        public bool IsUniqueUser(string username)
        {
            var user = _db.LocalUsers.FirstOrDefault(x => x.UserName == username);
            if (user == null)
            {
                return true;
            }
            return false;
        }

        public async Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<LocalUser> Register(RegistrationRequestDTO registrationRequestDTO)
        {
            LocalUser user = new()
            {
                UserName = registrationRequestDTO.UserName,
                Password = registrationRequestDTO.Password,
                Name = registrationRequestDTO.Name,
                Role = registrationRequestDTO.Role
            };

            _db.LocalUsers.Add(user);
            await _db.SaveChangesAsync();
            user.Password = "";
            return user;
        }
    }
}
