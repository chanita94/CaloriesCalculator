using Microsoft.AspNetCore.Mvc;
using Calories_Calculator.Models;
using System.Collections;

namespace Calories_Calculator.Controllers
{
    public class ResultsController : Controller
    {
        private readonly CaloriesDbContext _db;

        public ResultsController(CaloriesDbContext db)
        {

            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Result> objResults = _db.Results;
            return View(objResults);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var CaloriesFromDb = _db.Results.Find(id);
            if (CaloriesFromDb == null)
            {
                return NotFound();
            }
            return View(CaloriesFromDb);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Result obj)
        {

            if (ModelState.IsValid)
            {
                _db.Results.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);

        }
    }
}
