using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDeliciou.Controllers;

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
            return RedirectToAction("Index");
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
        Dishe? ViewDish = db.Dishes.FirstOrDefault(i => i.DishId == dishId);//view my dish by id

        if(ViewDish != null)
         {
            return View("DishInfos", ViewDish) ; //return view (Viewitem ) qui est dans la function DishInfos ki est la function
        }
           
         else 
         {
             return RedirectToAction("Index");
        }
    }



        [HttpPost("/Dishe/{dishId}/delete")]//puisque je n'ai pas un html file pour deletedish , je vais faire en sorte que apres avoir delete je retourne a index file
        public IActionResult DeleteDish(int dishId) 
        {
           Dishe? item = db.Dishes.FirstOrDefault(item => item.DishId == dishId);//delete my dish by id
           if(item != null) 
           { // if the id exists  in the Dishes database do the following
            db.Dishes.Remove(item);
            db.SaveChanges();
            Console.WriteLine("Entry removed");
        }
        return RedirectToAction("Index"); // regardless of if statement results please just go back to the index page
    }
    //if you doing the Redirect then you want the route in the quotation, if you want to do RedirectToaction you need the name of the method you are going to activate(no slash because you are talking directly to the method)

    //write a function to edit the dish
     [HttpGet("Dishe/{dishId}/edit")]
    public IActionResult EditDish(int dishId) {
        Dishe? item = db.Dishes.FirstOrDefault(item => item.DishId == dishId);
        if(item == null) {
            return RedirectToAction("DishInfos", dishId);
        } else {
            return View("EditDish",  item) ;
        }
    }


       [HttpPost("Dishe/{dishId}/update")]
    public IActionResult UpdateDish(Dishe newItem, int dishId){
        
        if(ModelState.IsValid){
            Dishe? oldItem = db.Dishes.SingleOrDefault(i => i.DishId == dishId);
            oldItem.DishName = newItem.DishName;
            oldItem.DishChef = newItem.DishChef;
            oldItem.DishTastiness = newItem.DishTastiness;
            oldItem.DishCalories = newItem.DishCalories;
            oldItem.DishDescription = newItem.DishDescription;
            oldItem.UpdatedAt = DateTime.Now;
            db.SaveChanges();
            return Redirect("/Dishe/{dishId}/dishinfos");
            // return RedirectToAction("DishInfos", dishId);this one is not working
        }
        else{ return View("editDish", dishId);}
       
    }




}
