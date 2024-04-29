using MenuRestos.Data.Interfaces;
using MenuRestos.Models;
using MenuRestos.Services.Interfaces;

namespace MenuRestos.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public RestaurantService(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }
        public IEnumerable<Restaurant> GetRestaurants(params long[] restaurantIds)
        {
            var restaurants = _restaurantRepository.Get(c => restaurantIds.Any(id => c.Id == id) || restaurantIds.Length == 0);

            foreach (var entity in restaurants)
                yield return EntityToModel.CreateCourseFromEntity(entity);
        }
    }
}
