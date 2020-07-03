using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_shastho.Models
{

        public class CoronaUpdateModel
        {
            public CoronaUpdateModel()
            {

            }
            public CoronaUpdateModel(CoronaUpdateModel coronaUpdateModel)
            {
                this.Date = coronaUpdateModel.Date;
                this.ActiveCases = coronaUpdateModel.ActiveCases;
                this.NewDailyCases = coronaUpdateModel.NewDailyCases;
                this.NewDailyDeaths = coronaUpdateModel.NewDailyDeaths;
                this.TotalCases = coronaUpdateModel.TotalCases;
                this.TotalDeaths = coronaUpdateModel.TotalDeaths;
                this.TotalRecoveries = coronaUpdateModel.TotalRecoveries;
            }

            public DateTime? Date { get; set; }
            public int ActiveCases { get; set; }
            public int NewDailyCases { get; set; }
            public int NewDailyDeaths { get; set; }
            public int TotalCases { get; set; }
            public int TotalRecoveries { get; set; }

            public int TotalDeaths { get; set; }
        }
   }
