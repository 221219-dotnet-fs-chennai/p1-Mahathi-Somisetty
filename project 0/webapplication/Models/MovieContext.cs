using Microsoft.EntityFrameworkCore;

namespace webapplication.Models
{
    public class MovieContext: DbContext
    {
        public MovieContext(DbContextOptions options) : base(options) 
        {
        }
        public DbSet<Movie> Movie { get; set; }


    }
}
