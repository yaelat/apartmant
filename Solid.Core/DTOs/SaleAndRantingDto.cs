using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class SaleAndRantingDto
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int CustomerId { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public double size { get; set; }
    }
}
