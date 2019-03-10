using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPresentation_GoodExamples.InterfaceSegregation
{
    interface IPlasticStatue
    {
        int Heigh { get; set; }
        int Width { get; set; }
        int Weight { get; set; }
    }
}
