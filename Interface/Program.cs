using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IPart[] parts = { new Basement(), new Door(), new Roof(), new Wall(), new Window()};
            Team workers = new Team(5, 20);
            TeamLeader prorab = new TeamLeader();
            House house = new House();

            bool finish = true;
            
            while (finish)
            {
                finish = false;

                if (house.CountBasement < 1)
                {
                    Console.WriteLine("Фундамент №{0}", house.CountBasement + 1);
                    if (workers.BuildPart(parts[0]))
                        house.CountBasement++;
                    finish = true;
                }
                else if (house.CountDoor < 1)
                {
                    Console.WriteLine("Дверь №{0}", house.CountDoor+1);
                    if (workers.BuildPart(parts[1]))
                        house.CountDoor++;
                    finish = true;
                }
                else  if (house.CountRoof < 1)
                {
                    Console.WriteLine("Крыша №{0}", house.CountRoof + 1);
                    if (workers.BuildPart(parts[2]))
                        house.CountRoof++;
                    finish = true;
                }
                else if (house.CountWall < 4)
                {
                    Console.WriteLine("Стена №{0}", house.CountWall + 1);
                    if (workers.BuildPart(parts[3]))
                        house.CountWall++;
                    finish = true;
                }
                else if (house.CountWindow < 4)
                {
                    Console.WriteLine("Окно №{0}", house.CountWindow + 1);
                    if (workers.BuildPart(parts[4]))
                        house.CountWindow++;
                    finish = true;
                }

                prorab.ShowReport(parts);
  
                workers.GiveMaterialsForWorker(10);

                ResetParts(parts);
            }

            Console.WriteLine("Ваш дом построен!!!");
            house.Show();
        }

        static void ResetParts(IPart[] parts)
        {
            for(int i = 0; i < parts.Length; i++)
            {
                if (parts[i].GetState() == true)
                    parts[i].Reset();
            }
        }
    }
}
