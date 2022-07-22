using Microsoft.AspNetCore.Mvc;
using VendAndTrack.Models;
using System.Collections.Generic;

namespace VendAndTrack.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendors/{VendorId}/orders/new")]
    public ActionResult New(int VendorId)
    {
      Vendor vendor = Vendor.Find(VendorId);
      return View(vendor);
    }

    [HttpPost("/orders/delete")]
    public ActionResult DeleteAll()
    {
      Order.ClearAll();
      return View();
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }

  }
}