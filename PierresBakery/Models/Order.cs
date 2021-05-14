using System.Collections.Generic;

namespace PierresBakery
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> { };
    
    public string OrderTitle { get; set; }
    public string OrderDescription { get; set; }
    public int OrderPrice { get; set; }
    public int Orderdate { get; set; }
    public int Id { get; }
    

    public Order(string orderTitle)
    {

    }
  }

  
}
