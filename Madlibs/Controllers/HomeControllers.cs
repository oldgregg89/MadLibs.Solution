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

    [Route("/form3")]
    public ActionResult Form3() { return View(); }

    [Route("/")]
    public ActionResult ChooseAMadlib () { return View(); }

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

    [Route("/MadlibAlbert")]
    public ActionResult MadlibAlbert (string place, string adjective1, string adjective2, string femaleCelebrity, string maleCelebrity, string noun1, string noun2, string noun3, string pluralNoun1, string pluralNoun2, string pluralNoun3, string pluralNoun4, string pluralProfession) 
    {
      EinsteinStory myMadlib = new EinsteinStory();
      myMadlib.FemaleCelebrity = femaleCelebrity;
      myMadlib.MaleCelebrity = maleCelebrity;
      myMadlib.Adjective1 = adjective1;
      myMadlib.Adjective2 = adjective2;
      myMadlib.Noun1 = noun1;
      myMadlib.Noun2 = noun2;
      myMadlib.Noun3 = noun3;
      myMadlib.PluralNoun1 = pluralNoun1;
      myMadlib.PluralNoun2 = pluralNoun2;
      myMadlib.PluralNoun3 = pluralNoun3;
      myMadlib.PluralNoun4 = pluralNoun4;
      myMadlib.Place = place;
      myMadlib.PluralProfession = pluralProfession;
      return View(myMadlib);
    }
    [Route("/MadlibInvention")]
    public ActionResult MadlibInvention (string adjective1, string adjective2, string adjective3, string adverb, string exclamation, string famousPerson1, string famousPerson2, string noun1, string noun2, string noun3, string noun4, string noun5, string number, string pluralNoun1, string pluralNoun2, string pluralFood, string typeOfLiquid)
    {
      InventionStory myMadlib = new InventionStory();
      myMadlib.Adjective1 = adjective1;
      myMadlib.Adjective2 = adjective2;
      myMadlib.Adjective3 = adjective3;
      myMadlib.Adverb = adverb;
      myMadlib.Exclamation = exclamation;
      myMadlib.FamousPerson1 = famousPerson1;
      myMadlib.FamousPerson2 = famousPerson2;
      myMadlib.Noun1 = noun1;
      myMadlib.Noun2 = noun2;
      myMadlib.Noun3 = noun3;
      myMadlib.Noun4 = noun4;
      myMadlib.Noun5 = noun5;
      myMadlib.Number = number;
      myMadlib.PluralNoun1 = pluralNoun1;
      myMadlib.PluralNoun2 = pluralNoun2;
      myMadlib.PluralFood = pluralFood;
      myMadlib.TypeOfLiquid = typeOfLiquid;
      return View(myMadlib);

    }
  }
}