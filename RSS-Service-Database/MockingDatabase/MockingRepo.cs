using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSS_Service_Database.MockingDatabase
{
    public class MockingRepo
    {
        private readonly List<RSS_Service_Library.ModelsNu.NuRss> _nuDatabase = new List<RSS_Service_Library.ModelsNu.NuRss>();
        private readonly List<RSS_Service_Library.ModelsTechRepublic.TechRepublicRss> _techRepublicRssDatabase = new List<RSS_Service_Library.ModelsTechRepublic.TechRepublicRss>();
        private readonly List<RSS_Service_Library.ModelsTechVisor.TechVisorRss> _techVisorRssdatabase = new List<RSS_Service_Library.ModelsTechVisor.TechVisorRss>();

        private static MockingRepo _mockingRepo;

        private MockingRepo()
        {

        }

        public static MockingRepo GetMockingRepo()
        {
            if (_mockingRepo == null)
            {
                _mockingRepo = new MockingRepo();
            }
            return _mockingRepo;
        }

        public List<RSS_Service_Library.ModelsNu.NuRss> GetNuDataBase()
        {
            return _nuDatabase;
        }

        public List<RSS_Service_Library.ModelsTechRepublic.TechRepublicRss> GetTechRepublicDataBase()
        {
            return _techRepublicRssDatabase;
        }

        public List<RSS_Service_Library.ModelsTechVisor.TechVisorRss> GetTechVisorDataBase()
        {
            return _techVisorRssdatabase;
        }

        public void AddToNuDatabse(RSS_Service_Library.ModelsNu.NuRss input)
        {   
            
            if (!_nuDatabase.Where(a => a.Text == input.Text).Any())
            {
                _nuDatabase.Add(input);
            }
        }

        public void AddToTechRepublicDataBase(RSS_Service_Library.ModelsTechRepublic.TechRepublicRss input)
        {
            if (!_techRepublicRssDatabase.Where(a => a.Text == input.Text).Any())
            {
                _techRepublicRssDatabase.Add(input);
            }
        }

        public void AddToTechVisorDataBase(RSS_Service_Library.ModelsTechVisor.TechVisorRss input)
        {
            if (!_techVisorRssdatabase.Where(a => a.Text == input.Text).Any())
            {
                _techVisorRssdatabase.Add(input);
            }
        }
    }
}
