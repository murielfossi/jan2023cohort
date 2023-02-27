using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
       public IActionResult Index()
    {
        string message = "Bonjour , je m'appelle Muriel je suis etudiante en software engineering, depuis plus de 1 mois et demi je suis en formation avec Coding Dojo  pour un travail de software developer.";
        return View("Index", message);
    }


    [HttpGet("/numbers")]
    public IActionResult Numbers(){
    int [] num = new int []{
        1,2,3,10,43,5};
    return View("numbers",num);
    }
   
    [HttpGet("/users")]
    public IActionResult Users(){
    List<User> users = new List<User>();
    users.Add (new User("Moose", "Phillips"));
    users.Add (new User("Sarah"));
    users.Add (new User("Jerry"));
    users.Add (new User("Rene", "Ricky"));
    users.Add (new User("Bar","barah"));


    return View ("users",users);

    }



    [HttpGet("/user")]

     public IActionResult User() {
        User firstUser = new User("Moose", "Phillips");
        return View("user",firstUser);
    }

    



  

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
