using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPresentation.InterfaceSegregation
{
    class Cap : IProduct
    {
        public int Price { get; set; } = 5;
        public int Heigh { get; set; }
        public int Width { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; } = "Black";
    }
}
