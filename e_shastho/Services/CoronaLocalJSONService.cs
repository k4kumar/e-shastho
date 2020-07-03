using e_shastho.Helpers;
using e_shastho.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace e_shastho.Services
{
    public class CoronaLocalJSONService
    {
        ApplicationConfig applicationConfig = new ApplicationConfig();
        public List<CoronaUpdateModel> GetCoronaLocalUpdate()
        {
            List<CoronaUpdateModel> coronaUpdateModels = new List<CoronaUpdateModel>();
            string fileName = "bangladesh_update.json";
            var path = Path.Combine(System.Web.HttpContext.Current.Server.MapPath("~/Content/Json/"), fileName);
            using (StreamReader r = new StreamReader(path))
            {
                    string json = r.ReadToEnd();
                dynamic stuff = JsonConvert.DeserializeObject(json);
                int oldcases = 0;
                int oldDeaths = 0;
                foreach (var elem in stuff)
                {
                    //var test = timelineitems[0][elem].new_daily_cases;

                    CoronaUpdateModel coronaUpdateModel = new CoronaUpdateModel
                    {
                        NewDailyCases = elem.Confirmed - oldcases,
                        NewDailyDeaths = elem.Deaths - oldDeaths,
                        TotalCases = elem.Confirmed,
                        ActiveCases = elem.Active,
                        TotalDeaths = elem.Deaths,
                        TotalRecoveries = elem.Recovered,
                        Date = Convert.ToDateTime(elem.Date)
                    };

                    oldDeaths = elem.Deaths;
                    oldcases = elem.Confirmed;
                    coronaUpdateModels.Add(coronaUpdateModel);
                }
                coronaUpdateModels = coronaUpdateModels.OrderByDescending(e => e.Date).ToList();
            }

            return coronaUpdateModels;
        }

    }
}