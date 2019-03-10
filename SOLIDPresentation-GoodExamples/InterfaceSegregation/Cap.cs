using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPresentation_GoodExamples.InterfaceSegregation
{
    class Cap : ICap, IProduct
    {
        public int CapSize { get; set; }
        public int Price { get; set; }
        public string Color { get; set; }
    }
}
