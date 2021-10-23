using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RSS_Service_Tests.Tests
{
    public class GeneralTests
    {
        [Fact]
        public void GET_NU_RSS_FEED_SUCCESFULL()
        {
            Assert.NotEmpty(RSS_Service_Library.Data_Retrieval.RSSDataWriter.NuRSSDataRetrieval());
        }

        [Fact]
        public void GET_TECH_REPUBLIC_RSS_FEED_SUCCESFULL()
        {
            Assert.NotEmpty(RSS_Service_Library.Data_Retrieval.RSSDataWriter.TechRepublicRSSDataRetrieval());
        }


        [Fact]
        public void GET_TECH_VISOR_RSS_FEED_SUCCESFULL()
        {
            Assert.NotEmpty(RSS_Service_Library.Data_Retrieval.RSSDataWriter.TechVisorRSSDataRetrieval());
        }
    }
}
