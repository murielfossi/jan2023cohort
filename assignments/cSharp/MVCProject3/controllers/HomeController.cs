using Microsoft.AspNetCore.Mvc;
namespace MVCProject3.Controllers;
    public class HomeController : Controller// make sure of this line
    {
        [HttpGet]
        [Route("")]
       
        public ViewResult home() {
            return View();
        }
    }
