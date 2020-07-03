using e_shastho.Data;
using e_shastho.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace e_shastho.Controllers
{
    public class HospitalController : Controller
    {

        HospitalService hospitalService = new HospitalService();
        public ActionResult Index()
        {
            List<Hospital> hospitals =  hospitalService.GetHospitals();
            return View(hospitals);
        }

        public ActionResult MapLocator()
        {
            List<Hospital> hospitals = hospitalService.GetHospitals();
            return View(hospitals);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Hospital model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            hospitalService.SaveHospital(model);

            return RedirectToAction(nameof(Index));
        }

    }
}