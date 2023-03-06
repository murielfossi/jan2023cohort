#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ChefsandDishes.Models;

public class Chef
{    [Key]
    public int ChefId {get; set;} // Auto generated Id do not need to put it inn the post method in the controller

    [Required]
    public string FirstName {get; set;}

    [Required]
    public string LastName {get; set;}


    [Required]
    [ChefAge]
    public DateTime BirthDate {get; set;}
    public DateTime CreatedAt { get; set; } = DateTime.Now; // Auto Generated
    public DateTime UpdatedAt { get; set; } = DateTime.Now; // Auto Generated

   //this list goes here because le chef aura la list de dishes, un chef peut faire beaucoup de nouriture
    public List<Dish> AllDishes {get; set;} = new List<Dish>();


   //je doit ecrire une function avec validation  pour avoir le date of birth correct 

    public int Age(){
        int currentDate = int.Parse(DateTime.Now.ToString("yyyMMdd"));
        int dob = int.Parse(BirthDate.ToString("yyyMMdd"));
        return (currentDate - dob) / 10000;
    }
}


    public class ChefAgeAttribute : ValidationAttribute
  {
    protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
    {   
        DateTime birth = (DateTime)value;
        int dob = int.Parse(birth.ToString("yyyyMMdd"));
        int currentDate = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
        int age = (currentDate - dob) / 10000;

        if(age < 18 )
            {return new ValidationResult("Chef must be at least 18 years old.");}
      
        else {return ValidationResult.Success;}
    
    }

   }   













