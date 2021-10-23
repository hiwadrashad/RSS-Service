using System;
using System.Collections.Generic;
using System.Text;

namespace RSS_Service_Library.Interfaces
{
    public interface IRepository
    {
        List<RSS_Service_Library.ModelsNu.NuRss> GetNuDataBase();
        List<RSS_Service_Library.ModelsTechRepublic.TechRepublicRss> GetTechRepublicDataBase();
        List<RSS_Service_Library.ModelsTechVisor.TechVisorRss> GetTechVisorDataBase();
        void AddToNuDatabse(RSS_Service_Library.ModelsNu.NuRss input);
        void AddToTechRepublicDataBase(RSS_Service_Library.ModelsTechRepublic.TechRepublicRss input);
        void AddToTechVisorDataBase(RSS_Service_Library.ModelsTechVisor.TechVisorRss input);
    }
}
