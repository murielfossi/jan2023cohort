//ici se sont les requirement que le user doit avoir pour login dans notre account. 
//c'est different du registration, on a besoin que de son email et de son password et de la confirmation
//ici tous les information exist dja dans le database puisque il a dja register, on doit juste mettre les infos et verifier que ca existe vraiment.

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