using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendorConstructor_Constructor()
    {
      Vendor newVendor = new Vendor("test", "test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorInformation_ReturnsDescription_String()
    {
      //Arrange
      string VendorName = "test";
      string VendorDescription = "test";
      Vendor newVendor = new Vendor(VendorName, VendorDescription);
      
      //Act
      string result = newVendor.VendorName;

      //Assert
      Assert.AreEqual(VendorName, result);

    }

    [TestMethod]

    public void GetAll_ReturnsEmptyList_VendorList()
    {
      //Arrange
      List<Vendor> newVendor = new List<Vendor>{ };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newVendor, result);
    }
  }
}