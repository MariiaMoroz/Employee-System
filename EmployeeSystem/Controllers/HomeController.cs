using EmployeeSystem.DAL;
using EmployeeSystem.Models;
using EmployeeSystem.ViewModels;
using System.Linq;
using System.Web.Mvc;



namespace EmployeeSystem.Controllers
{
    public class HomeController : Controller
    {
        private EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            IQueryable<HireDateGroup> data = from employee in db.Employees
                       group employee by employee.HireDate into dateGroup
                       select new HireDateGroup()
                       {
                        HireDate = dateGroup.Key,
                        EmployeeCount = dateGroup.Count()
                       };
            return View(data.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }

}
