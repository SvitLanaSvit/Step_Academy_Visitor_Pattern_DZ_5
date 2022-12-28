using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Visitor_Pattern_5
{
    public class Apartment : IChecking
    {
        public bool IsOk { get; set; } = true;
        public int RoomNumber { get; set; }
        public int Voltage { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitApartment(this);
        }
    }
}
