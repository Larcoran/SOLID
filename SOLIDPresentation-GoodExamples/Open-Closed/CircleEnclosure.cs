using SOLIDPresentation_GoodExamples.Open_Closed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPresentation.Open_Closed
{
    class CircleEnclosure : EnclosureShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
