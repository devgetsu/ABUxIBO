using EntityCoreLesson.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityCoreLesson.Infastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Company> Companys { get; set; }
    }
}
