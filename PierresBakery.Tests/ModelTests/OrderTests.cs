using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
   
   [TestMethod]
   public void OrderConstructor_WillCreateInstanceOfOrder_Order()
   {
     Order newOrder = new Order("Chiggady", "check", 0, 0);
     Assert.AreEqual(typeof(Order), newOrder.GetType());
   }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string orderTitle = "Test";
      string orderDescription = "CHECK";
      int orderPrice = 0;
      int orderDate = 0;
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);

      //Act
      string result = newOrder.OrderTitle;

      //Assert
      Assert.AreEqual(orderTitle, result);
    }

    [TestMethod]

    public void GetId_ReturnsOrderId_int()
    {
      //Arrange
      string orderTitle = "order testerer";
      string orderDescription = "CHECK";
      int orderPrice = 0;
      int orderDate = 0;
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);

      //Act
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      //Arrange
      string orderTitle = "order testerer";
      string orderDescription = "CHECK";
      int orderPrice = 0;
      int orderDate = 0;
      string orderTitle1 = "order testerer";
      string orderDescription1 = "CHECK";
      int orderPrice1 = 0;
      int orderDate1 = 0;
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      Order newOrder1 = new Order(orderTitle1, orderDescription1, orderPrice1, orderDate1);
      List<Order> ListOfOrders = new List<Order> {newOrder, newOrder1};

      //Act
      Order result = Order.Find(2);

      //Assert
      Assert.AreEqual(newOrder1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllOrderObjects_OrderList()
    {
      //Arrange
      string orderTitle = "order testerer";
      string orderDescription = "CHECK";
      int orderPrice = 0;
      int orderDate = 0;
      string orderTitle1 = "order testerer";
      string orderDescription1 = "CHECK";
      int orderPrice1 = 0;
      int orderDate1 = 0;
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      Order newOrder1 = new Order(orderTitle1, orderDescription1, orderPrice1, orderDate1);
      List<Order> ListOfOrders = new List<Order> {newOrder, newOrder1};

      //Act
      List<Order> result = Order.GetAll();
      
      //Assert
      CollectionAssert.AreEquivalent(ListOfOrders, result);
      
    }

  }
}