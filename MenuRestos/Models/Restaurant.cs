using System.ComponentModel.DataAnnotations;

namespace MenuRestos.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
