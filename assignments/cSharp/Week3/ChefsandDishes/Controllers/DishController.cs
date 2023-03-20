using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ChefsandDishes.Models;

namespace ChefsandDishes.Controllers;


public class DishController : Controller 
{

    private MyContext db;  // or use _context instead of db (Make sure this matches on all controller files)
    
    public DishController(MyContext context)
    {
        db = context; // if you use _context above use it here too (Make sure this matches on all controller files)
    }
    private int? uid {
        get {
            return HttpContext.Session.GetInt32("uid");
        }
    }

     [HttpGet("/adddish")]
    public IActionResult AddDishes() //cette function va display le form sur ma page web
    {ViewBag.Chefs=db.Chefs.ToList();//i need the chefs infos from the chefs database, i need those infos as a list that's why i used ToList
        return View("adddish");
    }


    
     [HttpPost("/createdish")]
    public IActionResult CreateDish(Dish d)
     {
        if(ModelState.IsValid) {
            // says hey db I got some info for you
            db.Dishes.Add(d);
            // says hey save that info I showed you
            db.SaveChanges();
            // Now since we saved it into the db there is an id attached so we can now print it as a way of verifying its there
            Console.WriteLine(d.DishId);

            return RedirectToAction("ViewDishes");
        } else {
            return View("createdish");
        }

    }


    [HttpGet("/viewdishes")]
    public IActionResult ViewDishes() //cette function va display tous les dishes sur ma page web
    {  List<Dish> allDishes = db.Dishes.Include(d => d.Author).ToList();
        
        return View(allDishes);
        
    }

    








}


