using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ArtStagram.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace ArtStagram.Controllers;

public class LikeController : Controller 
{

    private MyContext db;  // or use _context instead of db (Make sure this matches on all controller files)
    
    public LikeController(MyContext context)
    {
        db = context; // if you use _context above use it here too (Make sure this matches on all controller files)
    }
    private int? uid {
        get {
            return HttpContext.Session.GetInt32("uid");
        }
    }

private List<Post> Posts = new List<Post>();
private List<Like> Likes = new List<Like>();

   [HttpPost("/like/{postId}/createLike")]
    public ActionResult CreateLike(int postId, int userId, bool isLike)
    {
        var existingLike = Likes.FirstOrDefault(l => l.PostId == postId && l.UserId == userId);
        if (existingLike == null)
        {
            var like = new Like
            {
                LikeId = Likes.Count + 1,
                PostId = postId,
                UserId = userId,
                IsLike = isLike
            };
            Likes.Add(like);
            var post = Posts.FirstOrDefault(p => p.PostId == postId);
            if (post != null)
            {
                if (isLike)
                {
                    post.LikeCount++;
                }
                else
                {
                    post.UnLikeCount++;
                }
            }
        }
        else
        {
            existingLike.IsLike = isLike;
            var post = Posts.FirstOrDefault(p => p.PostId == postId);
            if (post != null)
            {
                if (isLike)
                {
                    post.LikeCount++;
                    post.UnLikeCount--;
                }
                else
                {
                    post.LikeCount--;
                    post.UnLikeCount++;
                }
            }
        }
        return RedirectToAction("Dashboard", "Post");
    }




    [HttpGet("/like/{postId}/addLike")]
    public ActionResult AddLike(int postId, int userId)
    {
        var existingLike = Likes.FirstOrDefault(l => l.PostId == postId && l.UserId == userId);
        ViewBag.PostId = postId;
        ViewBag.UserId = userId;
        ViewBag.IsLike = existingLike != null ? existingLike.IsLike : (bool?)null;
        return View("/addLike");
    }
}
















    
   
//     [SessionCheck]
//     [HttpGet("/like/{postId}/like")]
//     public IActionResult AddLike(int postId) {
//         int thePost = postId;
//         HttpContext.Session.SetInt32("thePost", thePost);
//         return View("AddLike");
//     }

    
//      private List<Like> likes = new List<Like>();
//     private List<Post> posts = new List<Post>();

//     [HttpPost("/Like/{postId}/createLike")]

//     public IActionResult CreateLike(Like l, int postId) {
//        var like = db.Likes.FirstOrDefault(l => l.UserId == userId && l.PostId == postId);
//         l.UserId = (int)uid;
//         l.PostId = postId;
       
        
//         if(ModelState.IsValid) {
//             Console.WriteLine("inside val check before .add");
//             db.Likes.Add(l);
//             db.SaveChanges();
//             return Redirect("/");
//         }     

//         return View("AddReply");
//     }
    
// }
    





















 // Recommend routeName and FunctionName be the same
//     [SessionCheck]
//     [HttpPost("/like/{postId}/createLike")]
//     public ActionResult Unlike( int postId)
//         {  var userId = (int)Session["UserId"];
           
            
//             var like = db.Likes.FirstOrDefault(l => l.UserId == userId && l.PostId == postId);
            
                
//             if (like != null)
//             {
//                 db.Likes.Remove(like);
//                 db.SaveChanges();
//             }
//             return RedirectToAction("Dashboard");
//         }
            
       
    

   
//     [HttpPost("/like/{postId}/createUnlike")]
    

//     // public async Task<IActionResult> Like(int postId)
//     // {
//     //     var post = db.Posts.FindAsync(postId);

//     //     if (post == null)
//     //     {
//     //         return NotFound("not found");
//     //     }

//     //     var userId = GetUserId();

//     //     if (post.UserId == userId)
//     //     {
//     //         return BadRequest("You cannot like your own post.");
//     //     }

//     //     if (post.Likes.Any(pl => pl.UserId == userId))
//     //     {
//     //         return BadRequest("You have already liked this post.");
//     //     }
//     //      var like = new Like {UserId = userId, PostId = postId};
//     //         db.Likes.Add(like);
//     //         db.SaveChanges();
//     //         return RedirectToAction("Dashboard");

      
//     // }

    
    
 
// }


