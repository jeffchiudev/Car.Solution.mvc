using Microsoft.AspNetCore.Mvc;
using TODOProjectName.Models;

namespace TODOProjectName.Controllers
{
    public class HomeController : Controller
    {
        [Route("/input")] //route for input form
        public ActionResult Input() { return View();}

        [Route("/output")] //out put route for taking variables to RAZOR
        public ActionResult Output(//define method parameters)
        {
            //InputVariable madLibVariable = new InputVariable();
            //madLibVariable.Country = country;
            //return View(madLibVariable);
        }
    }
}