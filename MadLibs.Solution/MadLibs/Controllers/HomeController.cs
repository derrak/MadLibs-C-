using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult InputForm()
    {
      return View();
    }


    [Route("madresult")]
    public ActionResult MadResult(string noun1, string adjective1, string verb1, string adverb1, string noun2, string adjective2, string pluralnoun1, string pluralnoun2, string pluralnoun3, string pluralnoun4, string partofbody1, string noun3, string noun4, string noun5, string noun6, string partofbody2)
    {
      MadLibsVariable myMadLibsVar = new MadLibsVariable();
      myMadLibsVar.Noun1 = noun1;
      myMadLibsVar.Adjective1 = adjective1;
      myMadLibsVar.Verb1 = verb1;
      myMadLibsVar.Adverb1 = adverb1;
      myMadLibsVar.Noun2 = noun2;
      myMadLibsVar.Adjective2 = adjective2;
      myMadLibsVar.PluralNoun1 = pluralnoun1;
      myMadLibsVar.PluralNoun2 = pluralnoun2;
      myMadLibsVar.PluralNoun3 = pluralnoun3;
      myMadLibsVar.PluralNoun4 = pluralnoun4;
      myMadLibsVar.PartOfBody1 = partofbody1;
      myMadLibsVar.Noun3 = noun3;
      myMadLibsVar.Noun4 = noun4;
      myMadLibsVar.Noun5 = noun5;
      myMadLibsVar.Noun6 = noun6;
      myMadLibsVar.PartOfBody2 = partofbody2;
      return View(myMadLibsVar);
    }
  }
}





