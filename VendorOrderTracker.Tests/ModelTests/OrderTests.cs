using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void MakeOrder_CreateInstanceOfOrder_Order()
    {
      Order newOrder = new Order("title", "description", 12, "date");
      //string test = "string";
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}