using Nancy;
using WordCounter.Objects;

namespace WordCounter
{
    public class HomeModule: NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };
            Post["/words_counted"] = _ => {
                string primeWord = Request.Form["prime-word"];
                string testString = Request.Form["test-string"];

                RepeatCounter newCounter = new RepeatCounter(primeWord, testString);
                newCounter.CountRepeats();
                return View["words_counted.cshtml", newCounter];
            };
        }
    }
}
