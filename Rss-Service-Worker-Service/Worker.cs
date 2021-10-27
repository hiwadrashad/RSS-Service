using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RSS_Service_Library.Strategies;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Rss_Service_Worker_Service
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var database = RSS_Service_Data_Base.Repositories.RssDbContextRepository.GetSingleton();
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    // string fullpath = System.IO.Directory.GetCurrentDirectory();
                    //string mainpath = Path.GetFullPath(Path.Combine(fullpath, @"..\..\"));
                    //File.AppendAllText(mainpath + @"RSS-Service\Rss-Service-Worker-Service\Logs\" + "log.txt", "Application started" + Environment.NewLine);

                    RSS_Service_Library.Strategies.NuRssStrategy NuStrategyImplementation = new NuRssStrategy();
                    RSS_Service_Library.Strategies.TechRepublicRssStrategy TechRepublicStrategyImplementation = new TechRepublicRssStrategy();
                    RSS_Service_Library.Strategies.TechVisorRssStrategy TechVisorStrategyImplementation = new TechVisorRssStrategy();
                    RSSDataRetrievalStrategy Strategy = new RSS_Service_Library.Strategies.RSSDataRetrievalStrategy();
                    Strategy.SetStrategy(NuStrategyImplementation);
                    var nureturnvalues = Strategy.ReturnRSSData<RSS_Service_Library.ModelsNu.NuRss>();
                    foreach (var item in nureturnvalues)
                    {
                        if (!database.GetNuRssData().Where(a => a.Channel.Title.ToString() == item.Channel.Title.ToString()).Any())
                        {
                            database.AddNuRss(item);
                            //File.AppendAllText(mainpath + @"RSS-Service\Rss-Service-Worker-Service\Logs\" + "log.txt", "Added article from Nu : " + item.Channel.Title.ToString() + Environment.NewLine);
                        }
                    }
                    Strategy.SetStrategy(TechRepublicStrategyImplementation);
                    var techrepublicreturnvalues = Strategy.ReturnRSSData<RSS_Service_Library.ModelsTechRepublic.TechRepublicRss>();
                    foreach (var item in techrepublicreturnvalues)
                    {
                        if (!database.GetTechRepublicRssData().Where(a => a.Channel.Title.ToString() == item.Channel.Title.ToString()).Any())
                        {
                            database.AddTechRepublicRss(item);
                            // File.AppendAllText(mainpath + @"RSS-Service\Rss-Service-Worker-Service\Logs\" + "log.txt", "Added article from Tech Republic : " + item.Channel.Title.ToString() + Environment.NewLine);
                        }
                    }
                    Strategy.SetStrategy(TechVisorStrategyImplementation);
                    var techvisorreturnvalues = Strategy.ReturnRSSData<RSS_Service_Library.ModelsTechVisor.TechVisorRss>();
                    foreach (var item in techvisorreturnvalues)
                    {
                        if (!database.GetTechVisorRssData().Where(a => a.Channel.Title.ToString() == item.Channel.Title.ToString()).Any())
                        {
                            database.AddTechVisorRss(item);
                            //File.AppendAllText(mainpath + @"RSS-Service\Rss-Service-Worker-Service\Logs\" + "log.txt", "Added article from Tech Visor : " + item.Channel.Title.ToString() + Environment.NewLine);
                        }
                    }
                    await Task.Delay(1000, stoppingToken);
                }
                catch (Exception ex)
                {
                    File.AppendAllText(@"E:\Programming\Windows-Service\Logs\" + "log.txt", ex.Message  + ex.Data + ex.StackTrace + ex.Source + ex.TargetSite + ex.HResult + ex.HelpLink + ex.InnerException + Environment.NewLine);
                }
            }
        }
    }
    
}
