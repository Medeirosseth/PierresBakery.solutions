using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Vendor
  {
    public string VendorName { get; set;}
    public string VendorDescription { get; set; }

    public int Id { get; }

    public List<Order> Orders { get; set; }

    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string vendorName, string vendorDescription)
    {
      VendorName = vendorName;
      VendorDescription = vendorDescription;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order> {};
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }
        public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public void GetOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}