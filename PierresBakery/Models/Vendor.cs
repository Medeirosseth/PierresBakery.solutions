using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Vendor
  {
    public string Description { get; set; }

    public int Id { get; }

    private static List<Vendor> _instances = new List<Vendor> {};


  }
}