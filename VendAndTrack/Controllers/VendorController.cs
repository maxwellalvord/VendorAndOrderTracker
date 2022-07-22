using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendAndTrack.Models;

namespace VendAndTrack.Controllers
{
  public class VedorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    
  }
} 