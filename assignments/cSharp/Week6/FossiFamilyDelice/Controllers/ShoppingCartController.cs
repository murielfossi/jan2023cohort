

using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using FossiFamilyDelice.Models;
using Microsoft.AspNetCore.Identity;//this help hash the password in the database

namespace FossiFamilyDelice.Controllers;

public class ShoppingCartController : Controller 
{

    private MyContext db;  
    public ShoppingCartController(MyContext context)
    {
        db = context; 
    }
    

      [SessionCheck]
    [HttpGet("/displayshoppingcart")]
    public IActionResult DisplayShoppingCart(ShoppingCart shop )
    { ShoppingCart? sc= db.ShoppingCarts.Include(s=>s.Food).SingleOrDefault(s => s.ShoppingCartId == shop.ShoppingCartId );
        return View(sc);
         
    }


    //  [SessionCheck]
    // [HttpPost("/food/{fooId}/addtoshoppingcart")]
    // public IActionResult AddFoodToShoppingCart (int foodId, int userid, int quantity)
    // {
    //         // ShoppingCart? cart= db.ShoppingCarts.FirstOrDefault(s => s.UserId == userId && s.FoodId == foodId);
    //         ShoppingCart cart = new ShoppingCart() {
    //             FoodId = foodId,
    //             UserId = (int)HttpContext.Session.GetInt32("uid")
    //         };
    //         db.ShoppingCarts.Add(cart);
    //         db.SaveChanges();
        
    //     return RedirectToAction("AllCartInfos");
    // }


    [SessionCheck]
    [HttpPost("/shoppingcart/{foodId}/addtoshoppingcart")]
    public IActionResult AddToShoppingCart(int foodId) 
    {
        int? userId = HttpContext.Session.GetInt32("uid");

        ShoppingCart? shoppingCart = db.ShoppingCarts.SingleOrDefault(s => s.FoodId == foodId && s.UserId == userId);
        Console.WriteLine(shoppingCart);
        
        

        if (shoppingCart == null) {
            Console.WriteLine("i am working");
            shoppingCart = new ShoppingCart
             {
                UserId = (int)userId,
                FoodId = foodId,
                Quantity = 1
             };

            db.ShoppingCarts.Add(shoppingCart);
            db.SaveChanges();
            shoppingCart =  db.ShoppingCarts.SingleOrDefault(s => s.FoodId == foodId && s.UserId == userId);
        }
        else 
        {
            shoppingCart.Quantity += 1;
            db.SaveChanges();
            // shoppingCart.TotalPrice;
        }


            return RedirectToAction("displayshoppingcart", shoppingCart);
        }

            
            
        




    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    