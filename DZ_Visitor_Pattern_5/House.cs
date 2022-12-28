using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Visitor_Pattern_5
{
    public class House : IChecking
    {
        List<Floor> electroshields = new ();
        public int NumberOfHouse { get; set; }
        public bool IsOk { get; set; } = true;

        public void Accept(IVisitor visitor)
        {
            bool isExists = electroshields.Exists(floor => floor.StateOfElectricShield < 50);
            if (isExists)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The condition of the shield in the house #{NumberOfHouse} is not working!");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (IChecking electroshield in electroshields)
                    electroshield.Accept(visitor);
                IsOk = false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The condition of the shield in the house #{NumberOfHouse} is working!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
        }

        public void AddFloor(Floor floor)
        {
            electroshields.Add(floor);
        }
    }
}
