using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IPart
    {
        int BuildPart(int materials);
        void ShowPart();
        bool GetState();
        int GetPerсantageOfPreparedness();
        void Reset();
    }
}
