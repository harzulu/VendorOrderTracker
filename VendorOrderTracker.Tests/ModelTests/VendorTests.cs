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
  }
}