using EntityFrameworkLesson.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkLesson.Controllers.INfrastructure
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
            :base(options)
        {
            
        }

        public DbSet<Car> Cars { get; set; }
    }
}
