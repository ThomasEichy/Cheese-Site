  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CheeseController.Controllers
{
    public class CheeseController : Controller
    {

        static private List<char> ValidChars = new List<char>(){ 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' '};
        static private bool errorCheck = false;


        public IActionResult Index()
        {
            ViewBag.cheeses = CheeseData.GetAll();

            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Subtract()
        {
            ViewBag.cheeses = CheeseData.GetAll();
            return View();
        }

        [HttpPost]
        [Route("/Cheese/Add")]
        public IActionResult NewCheese(string name, string description)
        {
            
            ViewBag.error = errorCheck;
            
            if (name == " ") {
                errorCheck = true;
                return Redirect("/Cheese/Add");
            }
            foreach (char letter in name){
                if (String.IsNullOrEmpty(name) || !ValidChars.Contains(char.ToLower(letter))){
                    errorCheck = true;
                    return Redirect("/Cheese/Add");
                }
            } 

            Cheese newCheese = new Cheese 
            {
                Name = name,
                Description = description
            };

            CheeseData.Add(newCheese);
            errorCheck = false;

            return Redirect("/Cheese");
        }

        [HttpPost]
        [Route("/Cheese/Subtract")]
        public IActionResult DeleteCheese(int[] cheeseIDs)
        {
            foreach ( int cheeseID in cheeseIDs ){
                CheeseData.Remove(cheeseID);
            }
            return Redirect("/Cheese");
        }
    }
}