using e_shastho.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace e_shastho.Services
{
    public class HospitalService
    {
        Entities entities = new Entities();
        public List<Hospital> GetHospitals()
        {
            return entities.Hospitals.ToList();
        }

        public bool SaveHospital(Hospital hospital)
        {
            entities.Hospitals.Add(hospital);
            return 1 == entities.SaveChanges();
        }
    }
}