using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using e_shastho.Data;
using e_shastho.Services;

namespace e_shastho.Controllers
{
    public class InfoController : Controller
    {
        InfoService infoService = new InfoService();
        // GET: Info
        public ActionResult Index()
        {
            List<Advice> advices = infoService.GetAdvices();
            return View(advices);
        }

        public ActionResult Details(int id)
        {
            Advice advice = infoService.GetDetails(id);
            return View(advice);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(Advice model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            infoService.SaveAdvice(model);

            return RedirectToAction(nameof(Index));
        }
    }
}