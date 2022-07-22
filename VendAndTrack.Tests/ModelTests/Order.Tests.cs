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
      
      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
     public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      string name = "Marks order";
      int price = 3;
      string name1 = "Maxs order";
      int price1 = 4;
      Order newOrder1 = new Order(description01, name, price);
      Order newOrder2 = new Order(description02, name1, price1);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string description = "3 croissants";
      string name = "Marks order";
      int price = 3;
      Order newOrder = new Order(description, name, price);

      //Act
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      //Arrange
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      string name = "Marks order";
      int price = 3;
      string name1 = "Maxs order";
      int price1 = 4;
      Order newOrder1 = new Order(description01, name, price);
      Order newOrder2 = new Order(description02, name1, price1);

      //Act
      Order result = Order.Find(2);

      //Assert
      Assert.AreEqual(newOrder2, result);
    }

  }
}