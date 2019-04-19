using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{

    //HelloController is extending the base Controller class(inherits from)

    public class HelloController : Controller
    {

        //The naming of the method below is how the controller knows where to route.
        //GET: /<controller>/

        public IActionResult Index()
        {
            return Content("<h1>Hello World</h1>", "text/html");
        }


        //current route /Home/Goodbye
        //change path of route
        [Route("Hello/Aloha")]
        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}