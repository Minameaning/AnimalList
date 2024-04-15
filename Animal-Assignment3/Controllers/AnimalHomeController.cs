using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Animal_Assignment3.Models;
using Microsoft.AspNetCore.Mvc;
using static Animal_Assignment3.Program;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Animal_Assignment3.Controllers
{
    public class AnimalHomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["ImageIndex"] = "https://i.pinimg.com/736x/58/9a/59/589a59a337fe1079467b5b53c0811c39.jpg"; // Set the image URL


            return View();
        }
        public IActionResult Animal()
        {
            // Create data for List of animals
            var animals = new List<AnimalList>
            {
                new AnimalList{Id =1,Name="Lion",Species="Panthera leo",Population="39,000",Image ="https://cdn-icons-png.flaticon.com/512/616/616412.png"},
                 new AnimalList { Id = 2, Name = "Elephant", Species = "Loxodonta", Population = "415,000", Image = "https://cdn-icons-png.flaticon.com/512/194/194204.png" },
                new AnimalList { Id = 3, Name = "Giraffe", Species = "Giraffa", Population = "97,500", Image = "https://cdn-icons-png.flaticon.com/512/1864/1864669.png" }
            };

            return View(animals);
        
        }
        public IActionResult About()
        {
            ViewData["Message"] = "This is about Animals Page.";
            ViewData["ImageAbout"] = "https://img.freepik.com/free-vector/wild-animal-group-white-background_1308-113144.jpg"; // Set the image URL
            return View();
        }
        public IActionResult Contact()
        {
     

            return View();
        }
    }
}

