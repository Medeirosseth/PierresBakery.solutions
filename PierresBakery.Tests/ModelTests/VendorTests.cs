using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendorConstructor_Constructor()
    {
      
      Vendor newVendor = new Vendor("TEST");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
      

      
    }
  }
}