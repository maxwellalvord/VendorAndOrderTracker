using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendAndTrack.Models;

namespace VendAndTrack.Tests
{
  [TestClass]
  public class OrderTests 
  // : IDisposable
  {

    // public void Dispose()
    // {
    //   Item.ClearAll();
    // }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test2", 1);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      // Arrange
      string description = "3 croissants";
      string name = "Marks order";
      int price = 3;
      Order newOrder = new Order(description, name, price);

      // Act
      string result = newOrder.Description;

      // Assert
      Assert.AreEqual(description, result);
    }

  }
}