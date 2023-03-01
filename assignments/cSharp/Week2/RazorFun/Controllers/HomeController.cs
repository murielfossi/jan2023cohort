using Microsoft.AspNetCore.Mvc;
namespace RazorFun.Controllers;
    public class HomeController : Controller// make sure of this line
    {
        [HttpGet]
        [Route("")]
       
        public ViewResult index() {
            //je vais un peux add le viewbag pour voir comment ca fonctionne.ca peux etre .Name,.Locaton,.Address etc...

            ViewBag.Name="your name";
            return View("Index");
        }

        //Je  peux utiliser le viewBag pour display les word ou infos sur ma deuxieme page web, je vais ecrire une list dans mon controler
        

        [HttpGet("/secondpage")]

        public ViewResult secondpage()
        {
            List<string> FoodList=new List<string>()
            
            {"Apple Pie",
            "Pizza",
            "Cinnamon Rolls",
            "Lasagna",
            "Donuts",
            "Chocolate Cake",
            "Burritos",
            "sanga",
            "Couscous Gombo",
           "Mais",
           "Plantain"
            
        };
            ViewBag.Message="hello Here are my favorite food!!!!";
            ViewBag.Foods=FoodList;

            return View("Secondpage");
        }


        //si je veux utiliser le redirecttoactionresult

         [HttpGet("/thirdpage")]
       public RedirectToActionResult thirdpage() {
        return RedirectToAction("Secondpage"); //avec cet action ci k j viens decrire, my Third web page is not available , because when you c;ick on the thirdpage link in index, it redirect you to the second page
       } 

    }
