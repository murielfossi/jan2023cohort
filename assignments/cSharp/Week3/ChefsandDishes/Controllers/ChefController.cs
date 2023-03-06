using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChefsandDishes.Models;

namespace ChefsandDishes.Controllers;

public class ChefController: Controller
{
    private MyContext db;

    public ChefController(MyContext context)
    {
        db = context;
    }




    
}