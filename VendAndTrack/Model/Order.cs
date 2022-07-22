using System.Collections.Generic;

namespace VendAndTrack.Models
{
  public class Order
  {
     public string Description { get; set; }
     public string Name { get; set; }
     public int Price { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {}; 

    public Order (string description, string name, int price)
    {
      Name = name;
      Price = price;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }
  }
}