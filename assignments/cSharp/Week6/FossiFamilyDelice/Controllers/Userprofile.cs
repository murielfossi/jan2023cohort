

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FossiFamilyDelice.Models;
using Microsoft.AspNetCore.Identity;//this help hash the password in the database

namespace FossiFamilyDelice.Controllers;

public class UserProfileController : Controller 
{

    private MyContext db;  
    public UserProfileController(MyContext context)
    {
        db = context; 
    }





        
    [SessionCheck]
    [HttpGet("/userprofile/adduserprofile")]
    public IActionResult AddUserProfile()
    {
        return View();
    }
    

    
    // [HttpPost("/userprofile/createuserprofile")]
    // public IActionResult CreateUserProfile(UserProfile up) {

        
    //     if(ModelState.IsValid) {

    //         db.UserProfiles.Add(up);//this create add it to the database and create it key value
    //         db.SaveChanges();
    //         HttpContext.Session.SetInt32("upid", up.UserProfileId);// we are adding the key value to session so we can use it
    //         return Redirect("AllUserInfos");
    //     }
    //     return View("AddUserProfile");
    // }

      [HttpPost("/userprofile/createuserprofile")]
    public IActionResult CreateUserProfile(UserProfile up) {
       
        up.UserId = (int) HttpContext.Session.GetInt32("uid");
        if(ModelState.IsValid) {
            db.UserProfiles.Add(up);
            db.SaveChanges();
            return Redirect("AllUserInfos");
        }
        return View("AddUserProfile");
    }



    //   [HttpGet("/post/{postId}/postinfos")]
    // public IActionResult PostInfos(int postId) {
    //     Post? item = db.Posts
    //     .Include(item => item.Author)
    //     .FirstOrDefault(item => item.PostId == postId);
    //     if(item == null) {
    //         return RedirectToAction("Dashboard");
    //     } else {
    //         return View("PostInfos", item);
    //     }
    // }

    [HttpGet("/userprofile/alluserinfos")]
    public IActionResult AllUserInfos(int userprofileId){
         UserProfile? item = db.UserProfiles
        .FirstOrDefault(item => item.UserProfileId == userprofileId);
        if(item == null) {
            return RedirectToAction("AddUserProfile");
        } else {
            return View("ViewAllUserInfos", item);
        }
    }
    


       
    
     [HttpGet("/viewalluserinfos")]
    public IActionResult ViewAllUserInfos() //cette function va display le form sur ma page web
    {
        return View("viewalluserinfos");
    }







}