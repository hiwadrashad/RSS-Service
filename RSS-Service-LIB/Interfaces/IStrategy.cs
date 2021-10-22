using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_Service_LIB.Interfaces
{
    public interface IStrategy<T>
    {
        List<T> DataWriting();
    }
}
