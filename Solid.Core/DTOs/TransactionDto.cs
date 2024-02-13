using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class TransactionDto
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int CustomerId { get; set; }
        public int SellerId { get; set; }
        public DateTime transactioDate { get; set; }
    }
}
