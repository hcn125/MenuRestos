using MenuRestos.Models;

namespace MenuRestos.DAL
{
    public class RestaurantRepository : IRestaurantRepository
    {

        private RestaurantContext _context;
        public RestaurantRepository(RestaurantContext restaurantContext)
        {
            this._context = restaurantContext;
        }
        public Restaurant GetRestaurantByID(int restaurantId)
        {
            return _context.Restaurants.Find(restaurantId);
        }
        public IEnumerable<Restaurant> GetRestaurants()
        {
            return _context.Restaurants.ToList();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
