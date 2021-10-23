using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_Service_Library.Interfaces
{
    public interface IStrategy
    {
        List<object> DataWriting();
    }
}
