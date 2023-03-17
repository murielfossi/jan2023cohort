#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace FossiFamilyDelice.Models;

public class Food{
    [Key]
    public int FoodId {get; set;}

  
    
    [Required]
   public string FoodName {get; set;}

   [Required ]
  
   public string FoodImg {get; set;}

    [Required]
    public string FoodDescription {get; set;}

    [Required]
    public float FoodPrice {get; set;}

    
    // add more attributes here
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    //one to many relationship between shoppingcart and Food
     public List<ShoppingCart> ShoppingCarts {get;set;}

 
   


}