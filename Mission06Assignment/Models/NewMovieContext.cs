using Microsoft.EntityFrameworkCore;

namespace Mission06Assignment.Models
{
    public class NewMovieContext : DbContext
    {
        public NewMovieContext(DbContextOptions<NewMovieContext> options) : base (options) //Constructor
        { 
        } 

        public DbSet<NewMovie> NewMovies { get; set; }
    }
}
