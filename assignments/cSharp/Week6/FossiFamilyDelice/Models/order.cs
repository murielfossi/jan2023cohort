#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace FossiFamilyDelice.Models;

public class Order{
    [Key]
    public int OrderId {get; set;}
    [Required]
    public string PaymentMethod {get; set;}
    [Required]
    public string   UserAddress {get;set;}

    [Required]
     [MinLength(10)]
     
    [DataType(DataType.PhoneNumber)]
    public string UserContact {get;set;}


    
    
    
    [Required]
    public float TotalPrice ;


    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;




    // this is  a one to one relationship between shopping cart and order
    public int ShoppingCartId {get; set;}
    public ShoppingCart? ShoppingCart {get;set;}


}