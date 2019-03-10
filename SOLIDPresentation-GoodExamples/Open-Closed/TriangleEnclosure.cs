using SOLIDPresentation_GoodExamples.Open_Closed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPresentation.Open_Closed
{
    class TriangleEnclosure:EnclosureShape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            return Height * Width * 0.5;
        }
    }
}
