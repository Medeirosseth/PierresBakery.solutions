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
    foreach (Vendor thisVendor in result)
      {
        Console.WriteLine("Output from empty list GettAll test: " + thisVendor.VendorName);
      }
      //Assert
      CollectionAssert.AreEqual(newVendor, result);
    }
    
    [TestMethod]

    public void GetAll_ReturnsVendors_VendorList()
    {
      //Arrange
      string VendorName = "testname";
      string VendorDescription = "testdescription";
      string vendorName1 = "testname1";
      string VendorDescription1 = "testdescription1";
      Vendor newVendor = new Vendor(VendorName, VendorDescription);
      Vendor newVendor1 = new Vendor(vendorName1, VendorDescription1);
      List<Vendor> newVendorList = new List<Vendor> { newVendor, newVendor1};

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newVendorList, result);
    }

    [TestMethod]

    public void GetId_VendorInstantiatesWithAnIsAndGetterReturns_Int()
    {
      //Arrange
      string vendorName = "test";
      string vendorDescription = "test";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]

    public void Find_ReturnsCorrectVendor_Find()
    {
      //Arrange
      string vendorName = "test 1,2,1,2";
      string vendorDescription = "test 1,2,1,2";
      string vendorName1 = "test uno, dos, uno, dos";
      string vendorDescription1 = "test uno, dos, uno, dos";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      Vendor newVendor1 = new Vendor(vendorName1, vendorDescription1);

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor1, result);

    }
  }
}