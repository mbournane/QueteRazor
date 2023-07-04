using Microsoft.AspNetCore.Mvc;
using QuestRazor.Models;

namespace QuestRazor.Controllers
{
    public class ExpenditureController : Controller
    {
        private List<Expenditure> Expenditures { get; set; }

        public ExpenditureController()
        {
            Expenditures = new List<Expenditure>()
            {
                new Expenditure(1, "Energie", DateTime.UtcNow, 75.50) ,
                new Expenditure(1, "Course", DateTime.UtcNow, 50.50),
                new Expenditure(1, "Téléphone", DateTime.UtcNow, 35.70)
             };
            ViewData["Expenditures"] = Expenditures;

        }
            


        
        public IActionResult Index()
        {
            return View(Expenditures);
        }
    }
}
