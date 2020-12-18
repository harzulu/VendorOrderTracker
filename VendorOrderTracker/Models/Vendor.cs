using System;
using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; set; }
    private static List<Vendor> _instances = new List<Vendor> { };
    public int Id { get; set; }

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Orders = new List<Order> { };
      _instances.Add(this);
      Id = _instances.Count;
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}