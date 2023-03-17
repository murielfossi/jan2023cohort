using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FossiFamilyDelice.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace FossiFamilyDelice.Controllers;

public class FoodController : Controller 
{

    private MyContext db;  // or use _context instead of db (Make sure this matches on all controller files)
    
    public FoodController(MyContext context)
    {
        db = context; // if you use _context above use it here too (Make sure this matches on all controller files)
    }
    private int? uid {
        get {
            return HttpContext.Session.GetInt32("uid");
        }
    }


     [SessionCheck]
      [HttpGet("/dashboard")]
    public IActionResult Dashboard()
    {
        if (HttpContext.Session.GetInt32("uid") == null)
        {
            return RedirectToAction("Index");
        }
        return View();
    }




     [SessionCheck]
    [HttpGet("/cameroonianspecialties")]
    public IActionResult CameroonianSpecialties()
    {
        return View();
    }

    [SessionCheck]
    [HttpGet("/food/addfood")]
    public IActionResult AddFood()
    {
        return View();
    }



        [HttpPost("/food/createfood")]
    public IActionResult CreateFood(Food f) {
        // f.FoodId = (int)uid;// don't need this because there is no relationship between the user and the food, i am adding all the food to the database
         
            db.Foods.Add(f);
            db.SaveChanges();

            
            return Redirect("Menu");
        
        
    }




        [SessionCheck]
    [HttpGet("/food/menu")]
    public IActionResult Menu() {

        List<Food> AllFoods = db.Foods
        // // .Include(p => p.Author)
        // .OrderByDescending(p => p.CreatedAt)//instead author it will be created at to have the most recent post in the to of my dashboard
        
        .ToList();
        return View("menu", AllFoods);
    }


 
    
    [SessionCheck]
    [HttpGet("/contactus")]
    public IActionResult ContactUs()
    {
        return View();
    }

     
    [SessionCheck]
    [HttpGet("/about")]
    public IActionResult About()
    {
        return View();
    }


























}
public class SessionCheckAttribute : ActionFilterAttribute
{

    public override void OnActionExecuting(ActionExecutingContext context)
    {
        // Find the session, but remember it may be null so we need int?
        int? uid = context.HttpContext.Session.GetInt32("uid");
        // Check to see if we got back null
        if(uid == null)
        {
            // Redirect to the Index page if there was nothing in session
            // "Home" here is referring to "HomeController", you can use any controller that is appropriate here
            context.Result = new RedirectToActionResult("Index", "Home", null);
        }
    }
}

    