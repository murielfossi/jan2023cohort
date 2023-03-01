#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace CRUDelicious.Models;

public class Dishe {
    [Key]
    public int DishId {get; set;} // Auto generated Id do not need to put it inn the post method in the controller
    [Required]
    public string DishName {get; set;}
    [Required]
    public string DishChef {get; set;}
    [Required]
    public string DishTastiness {get; set;}
      [Required]
    public string DishCalories {get; set;}
      [Required]
    public string DishDescription {get; set;}
    public DateTime CreatedAt { get; set; } = DateTime.Now; // Auto Generated
    public DateTime UpdatedAt { get; set; } = DateTime.Now; // Auto Generated
}