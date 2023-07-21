using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

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
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
        Vendor newVendor = new Vendor("test vendor");
        Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnName_String()
    {
        string name = "Test Vendor";
        Vendor newVendor = new Vendor(name);
        string result = newVendor.Name; //"result" is name of Test vendor Vendor
        Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
        string name = "test vendor";
        Vendor newVendor = new Vendor(name);
        int result = newVendor.Id;
        Assert.AreEqual(1, result);
    }
    }
}