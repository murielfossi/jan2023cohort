#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;//pour le password

// don't add column to database
public class UserProfile

{  
      [Key]
    public int UserProfileId {get; set;}




    [Required(ErrorMessage = "is required.")]
    [EmailAddress]
    public string Email { get; set; }


     [Required(ErrorMessage="The Username is required")]
    public string UserName {get; set;}
    

     [Required(ErrorMessage="Your address is required")]
    public string   UserAddress {get;set;}

      [Required(ErrorMessage="Your Contact is required")]
     [MinLength(10)]
     
    [DataType(DataType.PhoneNumber)]
    public string  UserContact {get;set;}


    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now; 


//one to many relationship between user and userprofile

    public int UserId {get; set;}
   

}