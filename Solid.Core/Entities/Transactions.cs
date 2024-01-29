using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solid.Core.Entities;
public class Transactions
{
    public int Id { get; set; }
    public int Price { get; set; }
    public int CustomerId { get; set; }
    public int SellerId { get; set; }
    [ForeignKey(nameof(CustomerId))]
    public Customer Customer { get; set; }
    [ForeignKey(nameof(SellerId))]
    public Customer Seller { get; set; }
    public DateTime transactioDate { get; set; }

}
