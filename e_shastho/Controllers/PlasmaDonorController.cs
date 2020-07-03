using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using e_shastho.Data;
using e_shastho.Services;

namespace e_shastho.Controllers
{
    public class PlasmaDonorController : Controller
    {
        PlasmaDonorService plasmaDonorService = new PlasmaDonorService();
        // GET: PlasmaDonor
        public ActionResult Index()
        {
            List<PlasmaDonor> plasmaDonors = plasmaDonorService.GetPlasmaDonors();
            return View(plasmaDonors);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PlasmaDonor model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            plasmaDonorService.SavePlasmaDonor(model);

            return RedirectToAction(nameof(Index));
        }
    }
}