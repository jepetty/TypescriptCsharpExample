using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SampleLibrary;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TypescriptCsharpExample
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var myString = "{\"name\": \"jessica\"}";
            var myJsonObject = JToken.Parse(myString);
            var finalString = JsonConvert.SerializeObject(myJsonObject);
            Console.WriteLine(finalString);

            Foo.WriteNiceThing();

            return View();
        }
    }
}
