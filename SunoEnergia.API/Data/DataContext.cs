using Microsoft.EntityFrameworkCore;
using SunoEnergia.API.Models;

namespace SunoEnergia.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DbContext> options) : base(options){}

        public DbSet<User> Users { get; set; }
    }
}