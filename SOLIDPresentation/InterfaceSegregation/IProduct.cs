using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPresentation.InterfaceSegregation
{
    interface IProduct
    {
        int Price { get; set; }
        int Heigh { get; set; }
        int Width { get; set; } 
        int Weight { get; set; }
        string Color { get; set; }

    }
}
