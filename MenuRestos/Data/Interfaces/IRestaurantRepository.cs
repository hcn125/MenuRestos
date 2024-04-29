using MenuRestos.Models;

namespace MenuRestos.Data.Interfaces
{
    public interface IRestaurantRepository : IRepositoryCrud<Restaurant>
    {
        IEnumerable<Restaurant?> Get(Func<object, bool> value);
    }
}
