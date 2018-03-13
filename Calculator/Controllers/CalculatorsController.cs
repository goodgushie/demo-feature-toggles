using System;
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

        public ActionResult Timezones()
        {
            return View();
        }

        /// <summary>
        /// Get the remainder when a is divided by b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a % b</returns>
        public int ModuloResult(int a, int b)
        {
            return CalculatorsHelper.Modulo(a, b);
        }

        /// <summary>
        /// Returns a random number
        /// </summary>
        /// <param name="max">Maximum number</param>
        /// <returns>Random number between 0 and the max</returns>
        public int RandomNumber(int max)
        {
            return FeaturesHelper.IsEnabled(2)
                ? CalculatorsHelper.RandomNumber(max)
                : CalculatorsHelper.BadRandomNumber(max);
        }

        /// <summary>
        /// An in development method for translating a datetime from the source timezone to the destination
        /// </summary>
        /// <param name="current">Current date and time</param>
        /// <param name="source">Current timezone</param>
        /// <param name="destination">Timezone to translate to</param>
        /// <returns>Datetime in the destination</returns>
        public DateTime ConverTime(DateTime current, TimeZone source, TimeZone destination)
        {
            return DateTime.UtcNow;
        }
    }
}