using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class OrderTests
  {
   
   [TestMethod]
   public void OrderConstructor_WillCreateInstanceOfOrder_Order()
   {
     Order newOrder = new Order("Chiggady check");
     Assert.AreEqual(typeof(Order), newOrder.GetType());
   }
  }
}