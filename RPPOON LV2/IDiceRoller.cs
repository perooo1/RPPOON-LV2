using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV2
{
    interface IDiceRoller
    {
        void RollAllDice();
        List<int> GetRollingResults();  //dodao sam ja zbog različite implementacije čuvanja bačenog broja nego što je u primjeru za LV
    }
}
