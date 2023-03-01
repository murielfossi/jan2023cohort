using Microsoft.AspNetCore.Mvc;
namespace MVCProject2.Controllers;     //be sure to use your own project's namespace!
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)


        public string Index()
        {
            return "This is my index!";
        }

        [HttpGet("/project")]
        public string Project() {
            return "This are my projects";
        }

        [HttpGet("/contact")]
        public string Contact() {
            return "This is my contact";
                
        }


        
    }

