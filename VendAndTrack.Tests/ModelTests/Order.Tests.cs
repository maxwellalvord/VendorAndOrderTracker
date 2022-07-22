using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendAndTrack.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests 
  // : IDisposable
  {

    // public void Dispose()
    // {
    //   Item.ClearAll();
    // }

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Order newItem = new Order("test");
      Assert.AreEqual(typeof(Order), newItem.GetType());
    }

  }
}