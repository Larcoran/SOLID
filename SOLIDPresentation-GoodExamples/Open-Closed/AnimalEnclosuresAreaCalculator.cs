using SOLIDPresentation_GoodExamples.Open_Closed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPresentation.Open_Closed
{
    class AnimalEnclosuresAreaCalculator
    {
        public double Area(EnclosureShape[] enclosures)
        {
            double area = 0;
            foreach (var enclosure in enclosures)
            {
                area += enclosure.Area();
            }
            return area;
        }
    }
}
