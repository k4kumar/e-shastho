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
    public class CoronaLocalUpdateService
    {
        public async Task<List<CoronaUpdateModel>> GetCoronaLocalUpdate()
        {
            List<CoronaUpdateModel> coronaUpdateModels = new List<CoronaUpdateModel>();
            using (var httpClient = new HttpClient())
            {
                try
                {
                    using (var response = await httpClient.GetAsync("https://api.covid19api.com/dayone/country/bangladesh"))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        dynamic stuff = JsonConvert.DeserializeObject(apiResponse);

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

                }
                catch
                {
                    return coronaUpdateModels;
                }
            }
            return coronaUpdateModels;
        }
    }
}