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
                RSSDataRetrievalStrategy Strategy = new RSS_Service_Library.Strategies.RSSDataRetrievalStrategy();
                Strategy.SetStrategy(NuStrategyImplementation);
                var returnvalues = Strategy.ReturnRSSData<RSS_Service_Library.ModelsNu.NuRss>();
                var item = returnvalues[0];
                Console.WriteLine(item.Channel.Title.ToString());
                Thread.Sleep(1000);
                //if (!storage.Where(a => a.Text == TestModel.Text).Any())
                //{
                //    storage.Add(TestModel);
                //}
                File.AppendAllText(mainpath + @"Logs\" + "log.txt", "Item" + Environment.NewLine);
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
