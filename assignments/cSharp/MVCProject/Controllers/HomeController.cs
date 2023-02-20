using Microsoft.AspNetCore.Mvc;
namespace MVCProject.Controllers;     //be sure to use your own project's namespace!
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]    //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public string Index()
        {
            return "Hello World from HelloController!";
        }
         [HttpGet("/hello")]    //type of request

        public string Hello()
        {
            return "Hello World from HelloController!";
        }
    }
