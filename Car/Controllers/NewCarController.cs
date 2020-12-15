using Microsoft.AspNetCore.Mvc;
using Car.Models; 
using System.Collections.Generic;

namespace Car.Controllers
{
    public class NewCarsController : Controller
    {
        [HttpGet("/newcars")]
        public ActionResult Index()
        {
            List<NewCar> allCars = NewCar.GetAll();
            return View(allCars);
        }

        [HttpGet("/newcars/new")]
        public ActionResult CreateCar()
        {
            return View();
        }

        [HttpPost("/newcars")]
        public ActionResult Create(string makeModel, int price, int miles)
        {
            NewCar myCar = new NewCar(makeModel, price, miles);
            return RedirectToAction("Index");
        }
    }
}