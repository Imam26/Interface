using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Interface
{
    class Worker : IWorker
    {
        private int materials;

        public int Materials
        {
            get => materials;
            set => materials = value;
        }

        //Если часть построена возвращает true иначе false
        public bool BuildPart(IPart part)
        {
            while(Materials != 0)
            {
                Materials-=1;
                Materials +=part.BuildPart(1);
                if (part.GetState() == true)
                    return true;
            }
            return false;
        }
    }
}