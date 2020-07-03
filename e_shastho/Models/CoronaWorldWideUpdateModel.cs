using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_shastho.Models
{
    public class CoronaWorldWideUpdateModel:CoronaUpdateModel
    {
        public CoronaWorldWideUpdateModel()
        {

        }
        public CoronaWorldWideUpdateModel(CoronaUpdateModel coronaUpdateModel)
            : base(coronaUpdateModel) { }
        public string Country { get; set; }
    }
}