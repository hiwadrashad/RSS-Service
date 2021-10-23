using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_Service_Library.Models
{
    public class TechRepublicMetaData
    {
        public int UpdateCount { get; set; }
        public List<string> Title { get; set; }
        public List<string> Date { get; set; }
    }
}
