using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendAndTrack.Models;

namespace VendAndTrack.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

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

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      string name = "Marks order";
      int price = 3;
      Order newOrder = new Order(description, name, price);

      //Act
      string updatedDescription = "Do the dishes";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };
      // Console.WriteLine(newList.Count);
      // Act
      List<Order> result = Order.GetAll();
      // Console.WriteLine(result.Count);

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

  }
}