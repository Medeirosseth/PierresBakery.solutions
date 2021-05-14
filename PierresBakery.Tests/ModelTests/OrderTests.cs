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

  }
}