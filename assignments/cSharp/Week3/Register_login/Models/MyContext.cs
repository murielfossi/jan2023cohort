//tout ce code Permet la relation entre mon code et ma database

#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;
namespace Register_login.Models;


//// the MyContext class represents a session with our MySQL database, allowing us to query for or save data
// DbContext is a class that comes from EntityFramework, we want to inherit its features
public class MyContext : DbContext 
{     // This line will always be here. It is what constructs our context upon initialization  
    public MyContext(DbContextOptions options) : base(options) { }    

   // Nous devons créer un nouveau DbSet<Model> nameofdatabase pour chaque modèle de notre projet qui crée une table
    // Le nom de notre table dans notre base de données sera basé sur le nom que nous fournissons ici
     // C'est ici que nous fournissons une version plurielle de notre modèle pour s'adapter aux normes de nommage des tables
    public DbSet<User> Users_regdb { get; set; } 
    
}