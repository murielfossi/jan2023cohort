using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;
    public class FormController : Controller// make sure of this line
    {
        [HttpGet]
        [Route("/result")]
       
        public ViewResult Result() {
            return View();
        }
        

        
    }
