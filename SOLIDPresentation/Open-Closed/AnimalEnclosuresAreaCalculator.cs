using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPresentation.Open_Closed
{
    class AnimalEnclosuresAreaCalculator
    {
        public double Area(object[] enclosures)
        {
            double area = 0;
            foreach (var enclosure in enclosures)
            {
                if (enclosure is RectangleEnclosure)
                {
                    RectangleEnclosure rectangeEnclosure = (RectangleEnclosure)enclosure;
                    area += rectangeEnclosure.Width * rectangeEnclosure.Height;
                }
                if(enclosure is CircleEnclosure)
                {
                    CircleEnclosure circleEnclosure = (CircleEnclosure)enclosure;
                    area += (circleEnclosure.Radius * circleEnclosure.Radius) * Math.PI;
                }
            }
            return area;
        }
    }
}
