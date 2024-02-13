using Solid.Core.Entities;

namespace Solid.Api.Models
{
    public class SaleAndRentingPostModel
    {
        public double Price { get; set; }
        public int CustomerId { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public double size { get; set; }
    }
}
