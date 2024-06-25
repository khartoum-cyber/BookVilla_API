using BookVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookVilla_VillaAPI.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }
        public DbSet<Villa> Villas { get; set; }
    }
}
