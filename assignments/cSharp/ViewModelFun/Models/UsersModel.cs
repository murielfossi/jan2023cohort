#pragma warning disable CS8618
namespace ViewModelFun.Models;


public class User
{
    public string FirstName {get;set;}
    public string LastName {get;set;}


    public User (string firstname , string lastname){
        FirstName=firstname;
        LastName=lastname;
    }

      public User (string firstname) {
        FirstName= firstname;
    } 

}
 

