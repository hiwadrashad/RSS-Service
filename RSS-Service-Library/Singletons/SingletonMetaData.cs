using RSS_Service_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_Service_Library.Singletons
{
    public class SingletonMetaData
    {
        private SingletonMetaData() { }

        private static NuMetaData _numetadata { get;set;}
        private static TechRepublicMetaData _techrepublicmetadata { get; set; }
        private static TechVisorMetaData _techvisormetadata { get; set; }


        private static SingletonMetaData _instance;

        public static SingletonMetaData GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SingletonMetaData();
            }
            if (_numetadata == null)
            {
                _numetadata = new NuMetaData();
            }
            if (_techrepublicmetadata == null)
            {
                _techrepublicmetadata = new TechRepublicMetaData();
            }
            if (_techvisormetadata == null)
            {
                _techvisormetadata = new TechVisorMetaData();
            }
            return _instance;
        }

        public NuMetaData getnumetadata()
        {
            return _numetadata;
        }
        public TechRepublicMetaData gettechrepublicmetadata()
        {
            return _techrepublicmetadata;
        }
        public TechVisorMetaData gettechvisormetadata()
        {
            return _techvisormetadata;
        }

        public void addnumetadatainfo(string title, string date)
        { 
           if (_numetadata.Date == null)
            {
                _numetadata.Date = new List<string>();
            }
            if (_numetadata.Title == null)
            {
                _numetadata.Title = new List<string>();
            }
            _numetadata.Title.Add(title);
            _numetadata.Date.Add(date);
        }

        public void addtechrepublicmetadatainfo(string title, string date)
        {
            if (_techrepublicmetadata.Date == null)
            {
                _techrepublicmetadata.Date = new List<string>();
            }
            if (_techrepublicmetadata.Title == null)
            {
                _techrepublicmetadata.Title = new List<string>();
            }
            _techrepublicmetadata.Title.Add(title);
            _techrepublicmetadata.Date.Add(date);
        }

        public void addtechvisormetadatainfo(string title, string date)
        {
            if (_techvisormetadata.Date == null)
            {
                _techvisormetadata.Date = new List<string>();
            }
            if (_techvisormetadata.Title == null)
            {
                _techvisormetadata.Title = new List<string>();
            }
            _techvisormetadata.Title.Add(title);
            _techvisormetadata.Date.Add(date);
        }

    }
}
