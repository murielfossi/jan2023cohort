
#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace FossiFamilyDelice.Models;


public class ShoppingCart
{
    [Key]
    public int ShoppingCartId { get; set; }
 
   
    [Required]
    public int Quantity {get;set;}
    
    [Required]
    public float TotalPrice ;
    // public decimal TotalPrice => FoodItems.Sum(item => item.FoodPrice);


      //one to many relationship between ShoppingCart and Food and user
       public int FoodId { get; set; }
       public Food? Food {get;set;}
       //one to many relationship between ShoppingCart  and user
       public int UserId {get; set;}
       public User? User {get;set;}
       //one to one relationship with order and shoppingCart
       public Order? Order {get; set;}












    //  public void AddItem(Food item)
    // {
    //     FoodItems.Add(item);
    // }

    // public void RemoveItem(Food item)
    // {
    //     FoodItems.Remove(item);
    // }

    // public void Clear()
    // {
    //     FoodItems.Clear();
    // }
}