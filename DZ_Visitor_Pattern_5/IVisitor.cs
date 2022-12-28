using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Visitor_Pattern_5
{
    public interface IVisitor
    {
        void VisitFloor(Floor floor);
        void VisitApartment(Apartment apartment);
    }
}
