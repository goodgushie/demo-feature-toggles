using System.Web.Mvc;
using Calculator.Helpers;

namespace Calculator.Controllers
{
    public class FeaturesController : Controller
    {
        // GET: Features
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FeaturesList()
        {
            return PartialView("FeaturesList", FeaturesHelper.Features);
        }

        public void ToggleFeature(int id)
        {
            FeaturesHelper.ToggleFeature(id);
        }

        public bool FeatureIsEnabled(int id)
        {
            return FeaturesHelper.IsEnabled(id);
        }
    }
}