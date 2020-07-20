using Microsoft.AspNetCore.Mvc;
using Madlib.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello!"; }

    [Route("/form")]
    public ActionResult Form() { return View(); }
    [Route("/MadlibPark")]
    public ActionResult MadlibPark (string adjective1, string adjective2, string noun1, string noun2, string noun3, string verb1, string verb2, string clothing, string feeling) 
    {
      ParkStory myMadlib = new ParkStory();
      myMadlib.Adjective1 = adjective1;
      myMadlib.Adjective2 = adjective2;
      myMadlib.Noun1 = noun1;
      myMadlib.Noun2 = noun2;
      myMadlib.Noun3 = noun3;
      myMadlib.Verb1 = verb1;
      myMadlib.Verb2 = verb2;
      myMadlib.Clothing = clothing;
      myMadlib.Feeling = feeling;
      return View(myMadlib);
    }
  }
}