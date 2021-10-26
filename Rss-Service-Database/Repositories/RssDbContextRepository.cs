using RSS_Service_Data_Base.Database;
using RSS_Service_Library.ModelsNu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using RSS_Service_Library.ModelsTechRepublic;
using RSS_Service_Library.ModelsTechVisor;

namespace RSS_Service_Data_Base.Repositories
{
    public class RssDbContextRepository
    {
        private RssDBContext _dbContext;

        private static RssDbContextRepository _instance;

        private RssDbContextRepository()
        {
            _dbContext = new RssDBContext();
        }

        public static RssDbContextRepository GetSingleton()
        {
            if (_instance == null)
            {
                _instance = new RssDbContextRepository();
            }
            return _instance;
        }

        public void ClearAllDataSets()
        {
            foreach (var item in _dbContext.NuDatabase)
            {
                _dbContext.NuDatabase.Remove(item);
            }
            foreach (var item in _dbContext.TechRepublicDatabase)
            {
                _dbContext.TechRepublicDatabase.Remove(item);
            }
            foreach (var item in _dbContext.TechVisorDatabase)
            {
                _dbContext.TechVisorDatabase.Remove(item);
            }
            _dbContext.SaveChanges();
        }

        public void AddTechRepublicRss(TechRepublicRss input)
        {
            _dbContext.Add(input);
            _dbContext.SaveChanges();
        }

        public void AddNuRss(NuRss input)
        {
            _dbContext.Add(input);
            _dbContext.SaveChanges();
        }
        public void AddTechVisorRss(TechVisorRss input)
        {
            _dbContext.Add(input);
            _dbContext.SaveChanges();
        }

        public List<NuRss> GetNuRssData()
        {
            return _dbContext.NuDatabase.ToList(); 
        }

        public List<TechRepublicRss> GetTechRepublicRssData()
        {
            return _dbContext.TechRepublicDatabase.ToList(); 
        }
        public List<TechVisorRss> GetTechVisorRssData()
        {
            return _dbContext.TechVisorDatabase.ToList(); ;
        }

    }
}
