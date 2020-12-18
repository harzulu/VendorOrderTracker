using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void MakeVendor_CreateInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("name", "description");
      string testing = "test";
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnGivenName_String()
    {
      string name = "TestName";

      Vendor newVendor = new Vendor(name, "description");

      Assert.AreEqual(name, newVendor.Name);
    }

    [TestMethod]
    public void GetDescription_ReturnGivenDescription_String()
    {
      string description = "TestDescription";

      Vendor newVendor = new Vendor("name", description);

      Assert.AreEqual(description, newVendor.Description);
    }

    [TestMethod]
    public void AddOrder_AddOrderToList_Order()
    {
      Order newOrder = new Order("Title", "Description", 12, "Date");
      Vendor newVendor = new Vendor("Name", "Description");

      newVendor.AddOrder(newOrder);

      Assert.AreEqual(newOrder, newVendor.Orders[0]);
    }

    [TestMethod]
    public void GetOrders_ReturnOrdersList_List()
    {
      Order newOrderOne = new Order("Title", "Description", 12, "Date");
      Order newOrderTwo = new Order("Title", "Description", 12, "Date");
      Order newOrderThree = new Order("Title", "Description", 12, "Date");

      Vendor newVendor = new Vendor("name", "description");
      List<Order> ordersList = new List<Order> {newOrderOne, newOrderTwo, newOrderThree};

      newVendor.AddOrder(newOrderOne);
      newVendor.AddOrder(newOrderTwo);
      newVendor.AddOrder(newOrderThree);

      CollectionAssert.AreEqual(ordersList, newVendor.Orders);
    }

    [TestMethod]
    public void GetId_ReturnIdOfVendor_Int()
    {
      Vendor newVendor = new Vendor("name", "description");
      Vendor newVendorTwo = new Vendor("name", "description");

      Assert.AreEqual(1, newVendor.Id);
    }
  }
}