using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using e_shastho.Data;
using e_shastho.Services;

namespace e_shastho.Controllers
{
    public class TestLocationController : Controller
    {
        TestLocationService testLocationService = new TestLocationService();
        // GET: TestLocation
        public ActionResult Index()
        {
            List<TestLocation> testLocations =  testLocationService.GetTestLocations();
            return View(testLocations);
        }

        public ActionResult MapLocator()
        {
            List<TestLocation> testLocations = testLocationService.GetTestLocations();
            return View(testLocations);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TestLocation model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            testLocationService.SaveTestLocation(model);

            return RedirectToAction(nameof(Index));
        }
    }
}