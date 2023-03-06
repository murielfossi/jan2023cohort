#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ChefsandDishes.Models;

public class Dish {
     [Key]
    public int DishId {get; set;} // Auto generated Id do not need to put it inn the post method in the controller
    [Required(ErrorMessage="The name of the dish is required")]
    public string DishName {get; set;}
    
    [Required(ErrorMessage="Taste is required")]
    [Range(1, 5, ErrorMessage = "Tastiness must be between 1 and 5")]
    public int DishTastiness {get; set;}

    [Required(ErrorMessage="Calories are required")]
    [Range(1, int.MaxValue)] //Calories must be greater than 0
    public int DishCalories {get; set;}

   
    public DateTime CreatedAt { get; set; } = DateTime.Now; // Auto Generated
    public DateTime UpdatedAt { get; set; } = DateTime.Now; // Auto Generated

   
    // add more attributes here
    

    public int ChefId {get; set;}
    public Chef? Author {get; set;} 
}