using Microsoft.EntityFrameworkCore;
using Mission06_Bird.Models;

namespace Mission06Assignment.Models
{
    public class NewMovieContext : DbContext
    {
        public NewMovieContext(DbContextOptions<NewMovieContext> options) : base (options) //Constructor
        { 
        } 

        public DbSet<NewMovie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
