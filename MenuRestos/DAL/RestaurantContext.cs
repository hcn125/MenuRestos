using MenuRestos.Models;
using Microsoft.EntityFrameworkCore;

namespace MenuRestos.DAL
{
    public class RestaurantContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=..\Data\Restaurants.db");

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
