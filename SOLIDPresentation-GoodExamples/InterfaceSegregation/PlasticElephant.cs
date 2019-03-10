using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPresentation_GoodExamples.InterfaceSegregation
{
    class PlasticElephant: IPlasticStatue, IProduct
    {
        public int Price { get; set; } = 50;
        public int Heigh { get; set; } = 10;
        public int Width { get; set; } = 8;
        public int Weight { get; set; } = 15;
        public string Color { get; set; } = "Blue";
    }
}
