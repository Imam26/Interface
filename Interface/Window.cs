using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Interface
{
    class Window:IPart
    {
        private int preparedness;
        const int result = 5;

        public int BuildPart(int materials)
        {
            if (preparedness + materials >= result)
            {
                int temp = preparedness;
                preparedness = result;
                return (materials + temp) - result;
            }

            preparedness += materials;
            return 0;
        }

        public void ShowPart()
        {
            Console.Write("-Окно-");
        }

        public bool GetState()
        {
            if (preparedness == result)
                return true;
            return false;
        }

        public int GetPerсantageOfPreparedness()
        {
            return (preparedness*100)/result;
        }

        public void Reset()
        {
            preparedness = 0;
        }
    }
}