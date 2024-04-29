using System.Data;
using System.Net.Http;
using MenuRestos.DAL;
using MenuRestos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MenuRestos.Controllers
{
    [ApiController]
    [Route("restaurant")]
    public class RestaurantController : Controller
    {
        private IRestaurantRepository _restaurantRepository;
        private readonly IHttpClientFactory _httpClientFactory;
        public readonly HttpClient? httpClient = null;
        public RestaurantController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _restaurantRepository = new RestaurantRepository(new RestaurantContext());
        }


        [Route("")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var students = _restaurantService.GetRestaurants();
            return new OkObjectResult(students);
        }
    }
}
