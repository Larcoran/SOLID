using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPresentation_GoodExamples.InterfaceSegregation
{
    interface IProduct
    {
        int Price { get; set; }
        string Color { get; set; }
    }
}
