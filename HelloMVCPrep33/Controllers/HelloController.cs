using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVCPrep33.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post'>" +
                "<input type='text' name='name' />" +
                "<input type='submit' value='Greet me!' />" +
                "</form>";
            return Redirect("/Hello/Goodbye");
        }

        // /Hello
        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "World")
        {
            return Content(String.Format("<h1>Hello, {0}!</h1>", name), "text/html");
        }

        // ?Hello/NAME (URL Segment) 
        [Route("/Hello/{name}")]

        public IActionResult Index2(string name)
        {
            return Content(String.Format("<h1>Hello, {0}!</h1>", name), "text/html");
        }


        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}
