#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;//pour le password

[NotMapped] // don't add column to database
public class LoginUser
{
    [Required(ErrorMessage = "is required.")]
    [EmailAddress]
    public string LoginEmail { get; set; }

    [Required(ErrorMessage = "is required.")]
    [DataType(DataType.Password)] 
    public string LoginPassword { get; set; }
}