using RSS_Service_Library.Interfaces;
using RSS_Service_Library.Strategies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RSS_Service_Windows_Service
{
    public partial class Service : ServiceBase
    {

        IRepository database = RSS_Service_Data_Base.MockingDatabase.MockingRepo.GetMockingRepo();
        public Service()
        {
            InitializeComponent();
        }
        public void OnDebug()
        {
            OnStart(null);
        }


        protected override void OnStart(string[] args)
        {
            string fullpath = System.IO.Directory.GetCurrentDirectory();
            string mainpath = Path.GetFullPath(Path.Combine(fullpath, @"..\..\"));
            File.AppendAllText(mainpath + @"Logs\" + "log.txt", "Application started" + Environment.NewLine);
            while (0 == 0)
            {
                RSS_Service_Library.Strategies.NuRssStrategy NuStrategyImplementation = new NuRssStrategy();
                RSS_Service_Library.Strategies.TechRepublicRssStrategy TechRepublicStrategyImplementation = new TechRepublicRssStrategy();
                RSS_Service_Library.Strategies.TechVisorRssStrategy TechVisorStrategyImplementation = new TechVisorRssStrategy();
                RSSDataRetrievalStrategy Strategy = new RSS_Service_Library.Strategies.RSSDataRetrievalStrategy();
                Strategy.SetStrategy(NuStrategyImplementation);
                var nureturnvalues = Strategy.ReturnRSSData<RSS_Service_Library.ModelsNu.NuRss>();
                foreach (var item in nureturnvalues)
                {
                    if (!database.GetNuDataBase().Where(a => a.Channel.Title.ToString() == item.Channel.Title.ToString()).Any())
                    {
                        database.AddToNuDatabse(item);
                        File.AppendAllText(mainpath + @"Logs\" + "log.txt", "Added article from Nu : " + item.Channel.Title.ToString() + Environment.NewLine);
                    }
                }
                Strategy.SetStrategy(TechRepublicStrategyImplementation);
                var techrepublicreturnvalues = Strategy.ReturnRSSData<RSS_Service_Library.ModelsTechRepublic.TechRepublicRss>();
                foreach (var item in techrepublicreturnvalues)
                {
                    if (!database.GetTechRepublicDataBase().Where(a => a.Channel.Title.ToString() == item.Channel.Title.ToString()).Any())
                    {
                        database.AddToTechRepublicDataBase(item);
                        File.AppendAllText(mainpath + @"Logs\" + "log.txt", "Added article from Tech Republic : " + item.Channel.Title.ToString() + Environment.NewLine);
                    }
                }
                Strategy.SetStrategy(TechVisorStrategyImplementation);
                var techvisorreturnvalues = Strategy.ReturnRSSData<RSS_Service_Library.ModelsTechVisor.TechVisorRss>();
                foreach (var item in techvisorreturnvalues)
                {
                    if (!database.GetTechVisorDataBase().Where(a => a.Channel.Title.ToString() == item.Channel.Title.ToString()).Any())
                    {
                        database.AddToTechVisorDataBase(item);
                        File.AppendAllText(mainpath + @"Logs\" + "log.txt", "Added article from Tech Visor : " + item.Channel.Title.ToString() + Environment.NewLine);
                    }
                }
                Thread.Sleep(1000);
            }
        }

        protected override void OnStop()
        {
            string fullpath = System.IO.Directory.GetCurrentDirectory();
            string mainpath = Path.GetFullPath(Path.Combine(fullpath, @"..\..\"));
            File.AppendAllText(mainpath + @"Logs\" + "log.txt", "Application ended" + Environment.NewLine);
        }
    }
}
