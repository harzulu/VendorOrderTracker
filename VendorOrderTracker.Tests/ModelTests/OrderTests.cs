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

    [TestMethod]
    public void GetTitle_ReturnTheGivenTitle_String()
    {
      string title = "TestTitle";

      Order newOrder = new Order(title, "description", 12, "date");

      Assert.AreEqual(title, newOrder.Title);
    }

    [TestMethod]
    public void GetDescription_ReturnGivenDescription_String()
    {
      string description = "TestDescription";

      Order newOrder = new Order("title", description, 12, "date");

      Assert.AreEqual(description, newOrder.Description);
    }

    [TestMethod]
    public void GetPrice_ReturnGivenPrice_Int()
    {
      int price = 12;

      Order newOrder = new Order("title", "description", price, "date");

      Assert.AreEqual(price, newOrder.Price);
    }
  }
}