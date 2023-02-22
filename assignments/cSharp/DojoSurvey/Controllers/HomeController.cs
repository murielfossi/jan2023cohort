using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;
    public class HomeController : Controller// make sure of this line
    {
        [HttpGet]
        [Route("")]
       
        public ViewResult Index() {
            return View();
        }


        
    }
