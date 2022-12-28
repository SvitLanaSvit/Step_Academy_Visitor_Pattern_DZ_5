using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Visitor_Pattern_5
{
    public class Floor : IChecking 
    {
        private readonly List<Apartment> apartments;
        public bool IsOk { get; set; } 
        public int StateOfElectricShield { get; private set; }
        public int FloorNumber { get; set; }
        private readonly Random rnd;

        public Floor(Random rnd)
        {
            apartments = new List<Apartment>();
            this.rnd = rnd;
            StateOfElectricShield = rnd.Next(100);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitFloor(this);
            foreach(var a in apartments)
            {
                visitor.VisitApartment(a);
            }
        }

        public void AddApartment(Apartment p)
        {
            apartments.Add(p);
            StateOfElectricShield = apartments.TrueForAll(apart => Math.Abs(apart.Voltage - 220) < 10) 
                ? rnd.Next(51,100) : rnd.Next(0,50);
        }
    }
}
