using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstMysqlConnection.Models;

namespace FirstMysqlConnection.Controllers;

public class SquishyController : Controller
{
    private MyContext db;

    public SquishyController(MyContext context)
    {
        db = context;
    }



    //method qui aura le http get==display my form in the tune.cshtml in the web page and post=add the infos enter to the database
    [HttpGet("/allsquishys")] // allSquishys is the name of my html file
    public IActionResult AllSquishys() 
    { //allsquishys html file  va dispaly la list de tous les squishies qui seront entree dans le form et irons etre stocke dans le database
        List<Squishy> allSquishys = db.Squishys.ToList();
        
        return View("AllSquishys", allSquishys);
    }

    [HttpGet("/addSquishy")]
    public IActionResult AddSquishy() //cette function va display le form sur ma page web
    {
        return View();
    }


    
    [HttpPost("/createSquishy")]
    public IActionResult CreateSquishy(Squishy s) {
        if(ModelState.IsValid) {
            // says hey db I got some info for you
            db.Squishys.Add(s);
            // says hey save that info I showed you
            db.SaveChanges();
            // Now since we saved it into the db there is an id attached so we can now print it as a way of verifying its there
            Console.WriteLine(s.SquishyId);
            return Redirect("/allSquishys");
        } else {
            return View("AddSquishy");
        }

    }
}





