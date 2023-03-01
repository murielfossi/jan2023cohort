using Microsoft.AspNetCore.Mvc;
namespace MVCProject3.Controllers;
    public class ContactController : Controller//make sure of this line
    {
        [HttpGet]
        [Route("/contact")]
       
        public ViewResult contact() {
            return View();
        }
    }
