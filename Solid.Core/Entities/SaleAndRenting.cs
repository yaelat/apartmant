using System;
namespace Solid.Core.Entities;
public class SaleAndRenting
{
	
	public int Id{ get; set; }
	public double Price { get; set; }
    public Customer Customer { get; set; }
    public int CustomerId { get; set; }
    public string Adress { get; set; }
    public string City { get; set; }
    public double size { get; set; }


}
