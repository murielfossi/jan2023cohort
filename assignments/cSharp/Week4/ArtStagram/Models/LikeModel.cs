#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ArtStagram.Models;

public class Like {
    [Key]
    public int LikeId {get; set;}
    [Required]
    public bool IsLike {get; set;}
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

// **** This is a many to many only table so it needs to just have the id's for both and connect with a name
    public int UserId {get; set;}
    public User? User {get; set;}

    public int PostId {get; set;}
    public Post? Post {get; set;}





private List<Post> Posts = new List<Post>();
private List<Like> Likes = new List<Like>();

public void CountLikesAndUnlikes(int postId)
{
    var postLikes = Likes.Where(l => l.PostId == postId).ToList();
    var likeCount = postLikes.Count(l => l.IsLike);
    var unlikeCount = postLikes.Count(l => !l.IsLike);

    var post = Posts.FirstOrDefault(p => p.PostId == PostId);
    if (post != null)
    {
        post.LikeCount = likeCount;
        post.UnLikeCount = unlikeCount;
    }
}


}



