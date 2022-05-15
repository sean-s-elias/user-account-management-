using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users {get; set;}
    }
}