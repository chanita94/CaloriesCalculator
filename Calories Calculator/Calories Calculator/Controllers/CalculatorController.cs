using Microsoft.AspNetCore.Mvc;
using Calories_Calculator.Models;


namespace Calories_Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly CaloriesDbContext _db;

        public CalculatorController(CaloriesDbContext db)
        {

            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Result obj)
        {

            _db.Results.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
