using Microsoft.AspNetCore.Mvc;
//using ProjectName.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello!"; }

    [Route("/form")]
    public ActionResult Form() { return View(); }
  }
}