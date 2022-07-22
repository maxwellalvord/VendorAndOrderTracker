using Microsoft.AspNetCore.Mvc;

namespace VendAndTrack.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}