#pragma warning disable CS8618

namespace FossiFamilyDelice.Models;

using Microsoft.EntityFrameworkCore;

public class MyContext : DbContext 
{     
    public MyContext(DbContextOptions options) : base(options) { }    

   
    public DbSet<User> Users { get; set; } 
    public DbSet<Food> Foods {get; set;}
    
   public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    public DbSet<Order> Orders { get; set; }

      public DbSet<UserProfile> UserProfiles {get;set;}
}