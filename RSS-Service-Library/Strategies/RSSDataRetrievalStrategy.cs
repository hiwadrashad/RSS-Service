using RSS_Service_Library.Data_Retrieval;
using RSS_Service_Library.Interfaces;
using RSS_Service_Library.ModelsNu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_Service_Library.Strategies
{
    public class RSSDataRetrievalStrategy
    {

        private IStrategy _strategy;

        public RSSDataRetrievalStrategy()
        { }
        public RSSDataRetrievalStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public List<T> ReturnRSSData<T>() where T : class
        {
            List<T> parsedreturnvalues = new List<T>();
            foreach (var item in _strategy.DataWriting())
            {
                parsedreturnvalues.Add(item as T);
            }
            return parsedreturnvalues;
        }

    }

    public class NuRssStrategy : IStrategy
    {
        public List<object> DataWriting()
        {
            var returnvalues = RSSDataWriter.NuRSSDataRetrieval();
            List<object> parsedvalue = new List<object>();
            foreach (var item in returnvalues)
            {
                parsedvalue.Add(item as object);
            }
            return parsedvalue;
        }
    }

    public class  TechRepublicRssStrategy : IStrategy
    {
        public List<object> DataWriting()
        {
            var returnvalues = RSSDataWriter.TechRepublicRSSDataRetrieval();
            List<object> parsedvalue = new List<object>();
            foreach (var item in returnvalues)
            {
                parsedvalue.Add(item as object);
            }
            return parsedvalue;
        }
    }

    public class TechVisorRssStrategy : IStrategy
    {
        public List<object> DataWriting()
        {
            var returnvalues = RSSDataWriter.TechVisorRSSDataRetrieval();
            List<object> parsedvalue = new List<object>();
            foreach (var item in returnvalues)
            {
                parsedvalue.Add(item as object);
            }
            return parsedvalue;
        }
    }
}
