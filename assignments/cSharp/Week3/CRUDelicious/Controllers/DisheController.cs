using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers;

public class DisheController: Controller
{
    private MyContext db;

    public DisheController(MyContext context)
    {
        db = context;
    }

//3 method to write

    //method qui aura le http get==display my form in the tune.cshtml in the web page and post=add the infos enter to the database
    [HttpGet("")] //je dirige tous les dishes que je vais creer ver le home page
    public IActionResult Index() 
    { 
        List<Dishe> allDishes = db.Dishes.ToList();//Dishe here is the name of the class in the model file
        
        return View("Index", allDishes);
    }


    

    [HttpGet("/adddish")]
    public IActionResult AddDishes() //cette function va display le form sur ma page web
    {
        return View("adddish");
    }
    
     [HttpPost("/createDish")]
    public IActionResult CreateSquishy(Dishe s)
     {
        if(ModelState.IsValid) {
            // says hey db I got some info for you
            db.Dishes.Add(s);
            // says hey save that info I showed you
            db.SaveChanges();
            // Now since we saved it into the db there is an id attached so we can now print it as a way of verifying its there
            Console.WriteLine(s.DishId);
            return Redirect("/Dishe/Index");
        } else {
            return View("createDish");
        }

    }

//display the dishinfos html page
      [HttpGet("/dishinfos")]
    public IActionResult DishInfos() //cette function va display le form sur ma page web
    {
        return View("dishinfos");
    }




    [HttpGet("/Dishe/{dishId}/dishinfos")]//this is going to route to Dishinfos with the id of each dish in the middle of the url
    public IActionResult DishInfos(int dishId)//defining a function
     {
        Dishe? ViewDish = db.Dishes.FirstOrDefault(i => i.DishId == dishId);

        if(ViewDish != null)
         {
            return View("DishInfos", ViewDish) ; //return view (Viewitem ) qui est dans la function DishInfos ki est la function
        }
           
         else 
         {
             return RedirectToAction("index");
        }
    }



    
}
