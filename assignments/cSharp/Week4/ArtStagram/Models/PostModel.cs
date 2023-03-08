#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ArtStagram.Models;

public class Post {
    [Key]
    public int PostId {get; set;}

    [Required(ErrorMessage="URL format please")]
    public string Img {get; set;}

    [Required]
    [MinLength(3, ErrorMessage="Title must be at least 3 characters long")] 
    public string Title {get; set;}

    [Required]
    [MinLength(3, ErrorMessage="Title must be at least 3 characters long")] 
    public string Medium {get; set;}

    [Required]
    public string ForSale {get; set;}
    
    // add more attributes here
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public int UserId {get; set;}
    public User? Author {get; set;} 

    public List<Like> AuthorLike {get; set;} = new List<Like>(); 


    [Required]
    public int LikeCount { get; set; }

     [Required]
    public int UnLikeCount { get; set; }


}