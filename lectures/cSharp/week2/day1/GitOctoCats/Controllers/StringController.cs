using Microsoft.AspNetCore.Mvc;
namespace GitOctoCats.Controllers;
    public class StringController : Controller
    {
        [HttpGet]
        [Route("/strings")]
        public string Strings()
        {
            return "Fun with Strings!";
        }
        // public ViewResult Index() {
        //     return View();
        // }
        [HttpGet("/strings/{name}")]//ici on testait comment si on change le nom a chaque foi la phrase aura un nouveau nom
        public string HelloName(string name) {
            return $"Hello there {name}, how are you today?";
        }

        [HttpGet("/strings/math/{a}/{b}")]//ici on rtestait comment ecrire avec les variable, si on tap strings/math/3/7 sur le browser on aura un resulta.
        public string Math(int a, int b) {
            int c = a * b;
            return $"You gave me {a} and {b}.  I have added them to now give you back {c}";
        }
    }

