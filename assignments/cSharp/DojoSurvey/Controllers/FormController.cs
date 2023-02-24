using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;
    public class FormController : Controller// make sure of this line
    {
        [HttpGet]
        [Route("/result")]
       
        public ViewResult Result() {
            return View();
        }


        
        [HttpPost("/result")]
        public IActionResult Result( string UserName, string Location, string Language, string Message ){
           ViewBag.UserName = $"{UserName}";
            ViewBag.Location = $"{Location}";
            ViewBag.Language = $"{Language}";
            ViewBag.Message =$"{Message}";
             
             return View("");
        }
        

        
    }
