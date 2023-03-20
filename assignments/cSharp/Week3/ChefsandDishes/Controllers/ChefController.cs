using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChefsandDishes.Models;
using Microsoft.EntityFrameworkCore;
namespace ChefsandDishes.Controllers;

public class ChefController: Controller
{
    private MyContext db;

    public ChefController(MyContext context)
    {
        db = context;
    }

    [HttpGet("/addchef")]
    public IActionResult AddChefs()

    {return View ("addChef");

    }

    [HttpPost("/createchef")]
    public IActionResult CreateChef(Chef form)
    {
        if(ModelState.IsValid)
        {
            db.Chefs.Add(form);
            db.SaveChanges();
            Console.WriteLine(form.ChefId); //this is just to make sure que ca a pri
            return RedirectToAction("ViewChefs");
        }
        else{return View("addchef");

        }
    }



    [HttpGet("/viewchefs")]
    public IActionResult ViewChefs()
    {
        // List<Chef> allChefs =db.Chefs.Include(d=>d.Author).ToList(); ceci n'a pas marcher parceque dans mon chef moldel chef on a plutot une list call alldishes donc on ne peux pas include all chef. jai plus envi ici de display mon form chef et alldishes mais en nombre
        List<Chef> chefs =db.Chefs.Include(c=>c.AllDishes).ToList();
        
        return View ("ViewChefs",chefs);
    }


    
}