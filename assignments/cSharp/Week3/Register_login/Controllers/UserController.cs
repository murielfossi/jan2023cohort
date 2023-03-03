//le user controller si control les deux model call userloginmodel et userregmodel

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Register_login.Models;
using Microsoft.AspNetCore.Identity;//this help hash the password in the database

namespace Register_login.Controllers;

public class UserController : Controller 
{

    private MyContext db;  // or use _context instead of db (Make sure this matches on all controller files)
    
    public UserController(MyContext context)
    {
        db = context; // if you use _context above use it here too (Make sure this matches on all controller files)
    }
    
    // Recommend routeName and FunctionName be the same
    
    [HttpGet("")]//ceci va display mon index qui a mon form reg et login dessus
    public IActionResult Index() {
        if(HttpContext.Session.GetInt32("uid") != null) {
            return RedirectToAction("Success");
        } else {
            return View("Index");
        }
    }

    //Je dois faire une function post pour le registration car ca va aller dans mon database
    [HttpPost("/register")]
    public IActionResult Register(User newUser)
    {
          //if the validation (tous les infos required)is not correct return la function Index qui display les deux f(register and login))
         if(!ModelState.IsValid) { return View("Index");}
           
         //Si la validation est corrrect hash la password dans le database        
         else 
       {
            PasswordHasher<User> hash = new PasswordHasher<User>(); // This creates a new instance of the password hasher so that we can use it on the next line
            newUser.Password = hash.HashPassword(newUser, newUser.Password);
            // let newUser.Password equal a hashed version of the password
            db.Users_regdb.Add(newUser);
            db.SaveChanges();

          //ici le session me permet de rester login, de garder mes infos dans le cookies pour que le user puisse login facilement la prochaine fois
            HttpContext.Session.SetInt32("uid", newUser.UserId);
            HttpContext.Session.SetString("name", newUser.FirstName + " " + newUser.LastName);
            return RedirectToAction("Success");
        }
    }

  //Muriel use a post for login  meme ci ca ne va pas save les infos du login dans mon database ca va quand meme verifier .only delete can use get or Post depending of the form
    [HttpPost("/login")]
    public IActionResult Login(LoginUser getUser) {
        if(!ModelState.IsValid) {
            return View("Index");} 

        else
        {
            User? userInDb = db.Users_regdb.FirstOrDefault(u => u.Email == getUser.LoginEmail);

            // Please go to db and see if there is an email that matched the email coming from the form
            if(userInDb == null) 
            {
                // If email is not in database go back to Index with new error for loginemail invalid email

                ModelState.AddModelError("LoginEmail", "Invalid Email");
                return View("Index");

            } 
            
            else 
            {    PasswordHasher<LoginUser> hash = new PasswordHasher<LoginUser>();

                var result = hash.VerifyHashedPassword(getUser, userInDb.Password, getUser.LoginPassword);

                
                if(result == 0)  // has the getUser password and see if they match will give bool type response
                { // meaning not a match return to index with this error
                    ModelState.AddModelError("LoginPassword", "Invalid Password");
                    return View("Index");}
                 else 
                {
                    HttpContext.Session.SetInt32("uid", userInDb.UserId);
                    HttpContext.Session.SetString("name", userInDb.FirstName + " " + userInDb.LastName);
                    return RedirectToAction("Success");
                }
            }   
        }
    }


    [HttpGet("/logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }


    
      [HttpGet("success")]
    public IActionResult Success()
    {
        if (HttpContext.Session.GetInt32("uid") == null)
        {
            return RedirectToAction("Index");
        }
        return View();
    }
}