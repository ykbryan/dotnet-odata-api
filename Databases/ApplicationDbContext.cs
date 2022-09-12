using Microsoft.EntityFrameworkCore;
using dotnet_odata_api.Models;

namespace dotnet_odata_api.Databases
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Movie>? Movie { get; set; }
    }
}