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

    [TestMethod]
    public void GetVendorInformation_ReturnsDescription_String()
    {
      //Arrange
      string VendorName = "marge";
      string VendorDescription = "wigDealer";
      Vendor newVendor = new Vendor(VendorName, VendorDescription);
      
      //Act
      string result = newVendor.VendorName;

      //Assert
      Assert.AreEqual(VendorName, result);

    }
  }
}