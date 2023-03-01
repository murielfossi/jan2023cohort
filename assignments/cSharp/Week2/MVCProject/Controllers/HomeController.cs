using Microsoft.AspNetCore.Mvc;
namespace MVCProject.Controllers;     //be sure to use your own project's namespace!
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]    //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public string Index()
        {
            return "This is my Index!";
        }
         [HttpGet("/hello")]    //type of request

        public string project()
        {
            return "These are my projects";
        }

          public string Contact()
        {
            return "This is my contacts!";
        }

    }
