using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;

namespace PierresBakery.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]

    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor vendorObject = Vendor.Find(id);
      List<Order> vendorOrders = vendorObject.Orders;
      model.Add("vendor", vendorObject);
      model.Add("orders", vendorOrders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]

    public ActionResult Create(int vendorId, string orderType, string orderDescription, int orderPrice, int orderDate)
    {
      Dictionary<string, Object> model = new Dictionary<string, object>();
      Vendor vendorObject = Vendor.Find(vendorId);
      Order newOrder = new Order(orderType, orderDescription, orderPrice, orderDate);
      List<Order> vendorOrders = vendorObject.Orders;
      vendorObject.GetOrder(newOrder);
      model.Add("vendor", vendorObject);
      model.Add("orders", vendorOrders);
      return View("Show", model);
    }
  }
}