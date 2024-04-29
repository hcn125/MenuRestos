using MenuRestos.Models;

namespace MenuRestos.DAL
{
    public interface IRestaurantRepository : IDisposable
    {
        IEnumerable<Restaurant> GetRestaurants();

        Restaurant GetRestaurantByID(int restaurantId);

        void Save();
    }
}
