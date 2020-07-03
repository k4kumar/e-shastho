using e_shastho.Models;
using e_shastho.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace e_shastho.Controllers
{
    public class CoronaUpdateController : Controller
    {
        private CoronaLocalJSONService coronaLocalUpdateService = new CoronaLocalJSONService();
        private CoronaWorldWideUpdateService coronaWorldWideUpdateService = new CoronaWorldWideUpdateService();

        // GET: CoronaUpdate
        public ActionResult Index()
        {
            List<CoronaUpdateModel> coronaUpdates = new List<CoronaUpdateModel>();
            coronaUpdates = coronaLocalUpdateService.GetCoronaLocalUpdate();
            return View(coronaUpdates);
        }

        public async Task<ActionResult> WorldUpdate()
        {
            List<CoronaWorldWideUpdateModel> coronaUpdates = new List<CoronaWorldWideUpdateModel>();
            coronaUpdates = await coronaWorldWideUpdateService.GetWorldWideUpdate();
            return View(coronaUpdates);
        }
    }
}