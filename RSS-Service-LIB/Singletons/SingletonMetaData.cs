using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_Service_LIB.Singletons
{
    public class SingletonMetaData
    {
        private SingletonMetaData() { }

        private static SingletonMetaData _instance;

        public static SingletonMetaData GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SingletonMetaData();
            }
            return _instance;
        }

        public static void Method()
        {
        }
    }
}
