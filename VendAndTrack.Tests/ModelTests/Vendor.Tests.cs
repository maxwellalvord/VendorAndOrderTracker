using System.Collections.Generic;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendAndTrack.Models;

namespace VendAndTrack.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }


    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      string name = "chucks";
      string description = "mexican food";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "chucks";
      string description = "mexican food";
      Vendor newVendor = new Vendor(name, description);

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "chucks";
      string description = "mexican food";
      Vendor newVendor = new Vendor(name, description);


      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name01 = "Work";
      string name02 = "School";
      string descript1 = "ball";
      string descript02 = "dog";
      Vendor newVendor1 = new Vendor(name01, descript1);
      Vendor newVendor2 = new Vendor(name02, descript02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
       string name01 = "Work";
      string name02 = "School";
      string descript1 = "ball";
      string descript02 = "dog";
      Vendor newVendor1 = new Vendor(name01, descript1);
      Vendor newVendor2 = new Vendor(name02, descript02);

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }
    [TestMethod]
    public void AddItem_AssociatesItemWithCategory_ItemList()
    {
      //Arrange
      string description = "3 croissants";
      string name = "Marks order";
      string price = "3";
      Order newOrder = new Order(description, name, price);
      List<Order> newList = new List<Order> { newOrder };
      string name01 = "chucks";
      string description01 = "mexican food";
      Vendor newVendor = new Vendor(name01, description01);
      newVendor.AddOrder(newOrder);

      //Act
      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}