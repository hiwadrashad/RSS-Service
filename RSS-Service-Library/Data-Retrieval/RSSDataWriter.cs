using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RSS_Service_Library.Data_Retrieval
{
    public class RSSDataWriter
    {
        public static List<RSS_Service_Library.ModelsTechVisor.TechVisorRss> TechVisorRSSDataRetrieval()
        {
            List<RSS_Service_Library.ModelsTechVisor.TechVisorRss> storage = new List<RSS_Service_Library.ModelsTechVisor.TechVisorRss>();
            string url = "https://www.techrepublic.com/rssfeeds/articles/";
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

            foreach (SyndicationItem item in feed.Items)
            {
                RSS_Service_Library.ModelsTechVisor.TechVisorRss Model = new RSS_Service_Library.ModelsTechVisor.TechVisorRss();
                Model.Channel = new RSS_Service_Library.ModelsTechVisor.Channel();
                Model.Channel.Item = new List<RSS_Service_Library.ModelsTechVisor.Item>();
                Model.Channel.Item.Add(new RSS_Service_Library.ModelsTechVisor.Item());

                Model.Channel.Title = item.Title.Text.ToString();

                Model.Channel.Item[0].PubDate = item.PublishDate.ToString();

                Model.Channel.Link = item.Links[0].Uri.ToString();

                storage.Add(Model);

            }
            RSS_Service_Library.ModelsTechVisor.TechVisorRss TestModel = storage[0];

            return storage;
        }


        public static List<RSS_Service_Library.ModelsNu.NuRss> NuRSSDataRetrieval()
        {
            List<RSS_Service_Library.ModelsNu.NuRss> storage = new List<RSS_Service_Library.ModelsNu.NuRss>();
            string url = "https://www.nu.nl/rss/Tech";
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

            foreach (SyndicationItem item in feed.Items)
            {
                RSS_Service_Library.ModelsNu.NuRss Model = new RSS_Service_Library.ModelsNu.NuRss();
                Model.Channel = new RSS_Service_Library.ModelsNu.Channel();
                Model.Channel.Item = new List<RSS_Service_Library.ModelsNu.Item>();
                Model.Channel.Item.Add(new RSS_Service_Library.ModelsNu.Item());
                Model.Channel.Item[0].Guid = new RSS_Service_Library.ModelsNu.Guid();

                Model.Channel.Item[0].Guid.Text = item.Id;

                Model.Channel.Title = item.Title.Text.ToString();

                Model.Channel.Item[0].PubDate = item.PublishDate.ToString();

                Model.Channel.Link = new System.Collections.Generic.List<string>();
                Model.Channel.Link.Add(item.Links[0].Uri.ToString());

                storage.Add(Model);

            }


            return storage;

        }

        public static List<RSS_Service_Library.ModelsTechRepublic.TechRepublicRss> TechRepublicRSSDataRetrieval()
        {
            List<RSS_Service_Library.ModelsTechRepublic.TechRepublicRss> storage = new List<RSS_Service_Library.ModelsTechRepublic.TechRepublicRss>();
            string url = "https://www.techrepublic.com/rssfeeds/articles/";
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

            foreach (SyndicationItem item in feed.Items)
            {
                RSS_Service_Library.ModelsTechRepublic.TechRepublicRss Model = new RSS_Service_Library.ModelsTechRepublic.TechRepublicRss();
                Model.Channel = new RSS_Service_Library.ModelsTechRepublic.Channel();
                Model.Channel.Item = new List<RSS_Service_Library.ModelsTechRepublic.Item>();
                Model.Channel.Item.Add(new RSS_Service_Library.ModelsTechRepublic.Item());
                Model.Channel.Item[0].Guid = new RSS_Service_Library.ModelsTechRepublic.Guid();

                Model.Channel.Item[0].Guid.Text = item.Id;

                Model.Channel.Title = item.Title.Text.ToString();

                Model.Channel.Item[0].PubDate = item.PublishDate.ToString();

                Model.Channel.Link = item.Links[0].Uri.ToString();

                storage.Add(Model);

            }

            RSS_Service_Library.ModelsTechRepublic.TechRepublicRss TestModel = storage[0];

            return storage;

        }
    }
}
