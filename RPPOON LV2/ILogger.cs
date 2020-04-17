using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV2
{
    ///////////////////////////////////////////////////////////  Z4
    /*
    interface ILogger
    {
        void Log(string message);     
    }
    */
    ///////////////////////////////////////////////////////////  Z5
    
    interface ILogger
    {
        void Log(ILogable data);
    }
    
}
