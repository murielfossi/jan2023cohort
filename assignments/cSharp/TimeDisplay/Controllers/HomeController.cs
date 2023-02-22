using Microsoft.AspNetCore.Mvc;
namespace TimeDisplay.Controllers;
    public class HomeController : Controller// make sure of this line
    {
        [HttpGet]
        [Route("")]
       
        public ViewResult Index() {
            return View();
        }
    }
