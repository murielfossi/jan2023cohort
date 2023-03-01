using Microsoft.AspNetCore.Mvc;
namespace MVCProject3.Controllers;//make sure of the name of your project
    public class ProjectsController : Controller//make sure of this line name of the controller
    {
        [HttpGet]
        [Route("/project")]
       
        public ViewResult project() {
            return View();
        }

       

    }
