using RSS_Service_LIB.Data_Retrieval;
using RSS_Service_LIB.Interfaces;
using RSS_Service_LIB.ModelsNu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_Service_LIB.Strategies
{
    public class RSSDataRetrievalStrategy<T>
    {

        private IStrategy<T> _strategy;

        public RSSDataRetrievalStrategy()
        { }
        public RSSDataRetrievalStrategy(IStrategy<T> strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IStrategy<T> strategy)
        {
            this._strategy = strategy;
        }

        public List<T> ReturnRSSData()
        {
            return (dynamic)this._strategy.DataWriting();

        }
    }

    class ConcreteStrategyA <T> : IStrategy<T>
    {
        public List<T> DataWriting()
        {
            return (dynamic)RSSDataWriter.NuRSSDataRetrieval();
        }
    }

    //class ConcreteStrategyB : IStrategy
    //{
    //    public object DoAlgorithm(object data)
    //    {
    //        var list = data as List<string>;
    //        list.Sort();
    //        list.Reverse();

    //        return list;
    //    }
    //}
}
