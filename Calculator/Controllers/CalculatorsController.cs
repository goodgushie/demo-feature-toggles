using System.Web.Mvc;
using Calculator.Helpers;

namespace Calculator.Controllers
{
    public class CalculatorsController : Controller
    {
        // GET: Calculators
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ByThrees()
        {
            return View();
        }

        public ActionResult RandomGenerator()
        {
            return View();
        }

        public int ModuloResult(int a, int b)
        {
            return CalculatorsHelper.Modulo(a, b);
        }

        public int RandomNumber(int max)
        {
            return FeaturesHelper.IsEnabled(2)
                ? CalculatorsHelper.RandomNumber(max)
                : CalculatorsHelper.BadRandomNumber(max);
        }
    }
}