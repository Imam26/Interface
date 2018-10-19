using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Interface
{
    class House
    {
        private string[] house;

        public int CountBasement { get; set; }
        public int CountDoor { get; set; }
        public int CountRoof { get; set; }
        public int CountWall { get; set; }
        public int CountWindow { get; set; }

        public House()
        {
            house = new string[10];

            house[0] = "       **       ";
            house[1] = "      ****      ";
            house[2] = "     *    *     ";
            house[3] = "    ********    ";
            house[4] = "    * **** *    ";
            house[5] = "    * **** *    ";
            house[6] = "    ********    ";
            house[7] = " ************** ";
            house[8] = " ************** ";
        }
        
        public void Show()
        {
            foreach(string str in house)
            {
                Console.WriteLine(str);
            }
        }
    }
}