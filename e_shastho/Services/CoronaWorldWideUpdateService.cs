using e_shastho.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace e_shastho.Services
{
    public class CoronaWorldWideUpdateService
    {
        public async Task<List<CoronaWorldWideUpdateModel>> GetWorldWideUpdate()
        {
            List<CoronaWorldWideUpdateModel> coronaUpdates = new List<CoronaWorldWideUpdateModel>();
            using (var httpClient = new HttpClient())
            {
                try
                {
                    using (var response = await httpClient.GetAsync("https://api.covid19api.com/summary"))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        dynamic stuff = JsonConvert.DeserializeObject(apiResponse);
                        foreach (var elem in stuff.Countries)
                        {
                            //var test = timelineitems[0][elem].new_daily_cases;

                            CoronaWorldWideUpdateModel coronaUpdate = new CoronaWorldWideUpdateModel
                            {
                                Country = elem.Country,
                                NewDailyCases = elem.NewConfirmed,
                                NewDailyDeaths = elem.NewDeaths,
                                TotalCases = elem.TotalConfirmed,
                                //ActiveCases = elem.Active,
                                TotalDeaths = elem.TotalDeaths,
                                TotalRecoveries = elem.TotalRecovered,
                                //Date = Convert.ToDateTime(elem.Date)
                            };


                            coronaUpdates.Add(coronaUpdate);
                        }
                    }
                }
                catch (Exception e)
                {
                    return coronaUpdates;
                }

            }
            return coronaUpdates;


        }
    }
}