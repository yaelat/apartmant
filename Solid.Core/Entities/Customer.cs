using System;
using System.ComponentModel.DataAnnotations;

namespace Solid.Core.Entities;
public class Customer
{
    public int Id { get; set; }
    public int Identify { get; set; }
    public string Name { get; set; }
    public string Number { get; set; }
    public string Email { get; set; }
}
