using Microsoft.EntityFrameworkCore;

namespace Calories_Calculator.Models
{
    public class CaloriesDbContext : DbContext
    {
        public CaloriesDbContext(DbContextOptions<CaloriesDbContext>options):base (options)
        {

        }
        public DbSet<Result>Results{get;set;}
    }
}
