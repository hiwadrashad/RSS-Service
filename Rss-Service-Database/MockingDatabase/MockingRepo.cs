using RSS_Service_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSS_Service_Data_Base.MockingDatabase
{
    public class MockingRepo : IRepository
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

                _nuDatabase.Add(input);
            
        }

        public void AddToTechRepublicDataBase(RSS_Service_Library.ModelsTechRepublic.TechRepublicRss input)
        {

                _techRepublicRssDatabase.Add(input);
            
        }

        public void AddToTechVisorDataBase(RSS_Service_Library.ModelsTechVisor.TechVisorRss input)
        {

                _techVisorRssdatabase.Add(input);
            
        }
    }
}
