

#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;// help me not to save the confirm password display in the form in the database.
namespace ArtStagram.Models;

public class User {
    [Key]
    public int UserId {get; set;}

    [Required(ErrorMessage="First name must be at least 2 characters")]
    public string Name {get; set;}

    [Required]
    [EmailAddress] // Set the type of email ,Email must be a valid email format
    [UniqueEmail] //email must be unique to the database
    public string Email {get; set;}
    
    [Required(ErrorMessage="Password must be at least 8 characters")]
    [DataType(DataType.Password)] // auto fills input type of password (specifically when using asp) (c'est se qui fait en sorte que tu visualises des ecriture cacher quand tu tappe ton mot de passe)
    public string Password {get; set;}

    [NotMapped] // please don't add me to the database, this one too is made to not save the confirm password in the database
    [Compare("Password", ErrorMessage="Dang it passwords don't match try your luck again")]
    public string Confirm {get; set;}
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now; 
    
    public List<Post> AuthorPost {get; set;} = new List<Post>();
    public List<Like> AuthorLike {get; set;} = new List<Like>(); 



}
//This specifiq function make the email unique so a user cannot use multiple email to login, this will help us retrieve a user by his email 
public class UniqueEmailAttribute : ValidationAttribute {
    protected override ValidationResult? IsValid(object? value, ValidationContext valContext) {
        if(value == null) { // if email input is empty
            return new ValidationResult("Email is required");
        }
        MyContext _context = (MyContext)valContext.GetService(typeof(MyContext));
        if(_context.Users.Any(e => e.Email == value.ToString())) {
            return new ValidationResult("Email is in use"); // if email is in database
        } else {
            return ValidationResult.Success; // email not in database good to go
        }
    }



  
}