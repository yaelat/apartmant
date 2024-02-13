using Solid.Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solid.Api.Models
{
    public class TransactionPostModel
    {
        public int Price { get; set; }
        public int CustomerId { get; set; }
        public int SellerId { get; set; }            
        public DateTime transactioDate { get; set; }
    }
}
