using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using e_shastho.Data;

namespace e_shastho.Services
{
    public class PlasmaDonorService
    {
        Entities entities = new Entities();
        public List<PlasmaDonor> GetPlasmaDonors()
        {
            return entities.PlasmaDonors.Where(e => e.IsVerified).ToList();
        }

        public bool SavePlasmaDonor(PlasmaDonor plasmaDonor)
        {
            entities.PlasmaDonors.Add(plasmaDonor);
            return 1 == entities.SaveChanges();
        }
    }
}