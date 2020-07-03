using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using e_shastho.Data;

namespace e_shastho.Services
{
    public class TestLocationService
    {
        Entities entities = new Entities();
        public List<TestLocation> GetTestLocations()
        {
            return entities.TestLocations.ToList();
        }

        public bool SaveTestLocation(TestLocation testLocation)
        {
            entities.TestLocations.Add(testLocation);
            return 1 == entities.SaveChanges();
        }
    }
}