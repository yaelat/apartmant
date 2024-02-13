using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solid.Core.Entities;
public class Transactions
{
    public int Id { get; set; }
    public int Price { get; set; }
    public int CustomerId { get; set; }
    public int SellerId { get; set; }

    [ForeignKey("CustomerId"), Column(Order = 0)]
    public Customer Customer { get; set; }

    [ForeignKey("SellerId"), Column(Order = 1)]
    public Customer Seller { get; set; }
    public DateTime transactioDate { get; set; }

}
