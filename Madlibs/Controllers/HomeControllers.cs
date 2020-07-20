using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello!"; }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/form2")]
    public ActionResult Form2() { return View(); }

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

    [Route("/")]
    public ActionResult ChooseAMadlib ()
    {
      
    }

    [Route("/MadlibAlbert")]
    public ActionResult MadlibAlbert (string place, string adjective1, string adjective2, string femaleCelebrity, string maleCelebrity, string noun1, string noun2, string noun3, string pluralNoun1, string pluralNoun2, string pluralNoun3, string pluralNoun4, string pluralProfession) 
    {
      AlbertEinstein myMadlib = new AlbertEinstein();
      myMadlib.FemaleCelebrity = femaleCelebrity;
      myMadlib.MaleCelebrity = maleCelebrity;
      myMadlib.Noun1 = noun1;
      myMadlib.PluralNoun1 = pluralNoun1;
      myMadlib.Adjective1 = adjective1;
      myMadlib.PluralNoun2 = pluralNoun2;
      myMadlib.Adjective2 = adjective2;
      myMadlib.PluralNoun3 = pluralNoun3;
      myMadlib.Noun2 = noun2;
      myMadlib.Place = place;
      myMadlib.PluralNoun4 = pluralNoun4;
      myMadlib.Noun3 = noun3;
      myMadlib.PluralProfession = pluralProfession;
      return View(myMadlib);
    }
  }
}