using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Vendor
  {
    public string VendorName { get; set;}
    public string VendorDescription { get; set; }

    public int Id { get; }

    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string test)
    {

    }
  }
}