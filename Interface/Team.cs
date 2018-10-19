using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Interface
{
    class Team:IWorker
    {
        private Worker[] workers;

        public Team(int count, int totalMaterials)
        {
            workers = new Worker[count];
            for(int i = 0; i < count; i++)
            {
                workers[i] = new Worker();
            }
            GiveMaterialsForWorker(totalMaterials);
        }

        public bool BuildPart(IPart part)
        {
            foreach(Worker worker in workers)
            {
                if (worker.BuildPart(part))
                    return true;
            }
            return false;
        }

        public void GiveMaterialsForWorker(int totalMaterials)
        {
            if (WorkerState() == false)
            {
                int partOfMaterials = totalMaterials / workers.Length;
                int remain = totalMaterials % workers.Length;

                foreach (Worker worker in workers)
                {
                    worker.Materials += partOfMaterials;
                }

                workers[workers.Length - 1].Materials += remain;
            }
        }

        private bool WorkerState()
        {
            int countOfMaterials = 0;

            foreach (Worker worker in workers)
            {
                countOfMaterials += worker.Materials;
            }

            return countOfMaterials == 0 ? false : true;
        }
    }
}