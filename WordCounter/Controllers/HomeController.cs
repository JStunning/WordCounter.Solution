using WordCounter.Models;
using Microsoft.AspNetCore.Mvc;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult WordCounter() { return View(); }

    [Route("/result")]
    public ActionResult Result(string word, string sentence)
    {
      RepeatCounter myRepeatCounter = new RepeatCounter();
      myRepeatCounter.SetWordAndSentence(word, sentence);
      myRepeatCounter.AllSymbolRemover();
      myRepeatCounter.FindMatch();
      return View(myRepeatCounter);
    }
  }
}