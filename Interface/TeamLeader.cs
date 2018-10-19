using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Interface
{
    class TeamLeader
    {
        public void ShowReport(IPart[] parts)
        {
            for(int i = 0; i<parts.Length; i++)
            {
                if (parts[i].GetState())
                {
                    parts[i].ShowPart();
                    Console.WriteLine("Построено!!!");
                    Console.WriteLine("----------------");
                }
                else if(parts[i].GetPerсantageOfPreparedness() !=0)
                    Console.WriteLine("Процент готовности: {0}", parts[i].GetPerсantageOfPreparedness());
            }
        }
    }
}