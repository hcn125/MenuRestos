using MenuRestos.Models;

namespace MenuRestos.Services.Interfaces
{
    public interface IRestaurantService
    {
        IEnumerable<Restaurant> GetRestaurants(params long[] restaurantIds);
    }
}
