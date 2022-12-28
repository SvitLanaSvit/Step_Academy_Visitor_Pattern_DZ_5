using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Visitor_Pattern_5
{
    public class ElectricVisitor : IVisitor
    {
        public void VisitApartment(Apartment apartment)
        {
            if(Math.Abs(apartment.Voltage - 220) < 10)
            {
                Console.WriteLine($"In the room {apartment.RoomNumber} with voltage is everithing ok.");
            }
            else
            {
                apartment.IsOk = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"In the room {apartment.RoomNumber} with voltage is problem.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void VisitFloor(Floor floor)
        {
            if(floor.StateOfElectricShield > 50)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"On the floor #{floor.FloorNumber} with voltage is everithing ok.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                floor.IsOk = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"On the floor #{floor.FloorNumber} with voltage is problem.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
