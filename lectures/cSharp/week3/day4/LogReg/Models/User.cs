#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;// help me not to save the confirm password display in the form in the database.
namespace LogReg.Models;

public class User {
    [Key]
    public int UserId {get; set;}
    [Required]
    [Display(Name="First Name")] // If using asp-for in label this lets you customize what the label shows
    public string FirstName {get; set;}

    [Required]
    public string LastName {get; set;}

    [Required]
    [EmailAddress] // Set the type of email
    [UniqueEmail]
    public string Email {get; set;}
    
    [Required]
    [DataType(DataType.Password)] // auto fills input type of password (specifically when using asp) (c'est se qui fait en sorte que tu visualises des ecriture cacher quand tu tappe ton mot de passe)
    public string Password {get; set;}

    [NotMapped] // please don't add me to the database, this one too is made to not save the confirm password in the database
    [Compare("Password", ErrorMessage="Dang it passwords don't match try your luck again")]
    public string Confirm {get; set;}
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
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