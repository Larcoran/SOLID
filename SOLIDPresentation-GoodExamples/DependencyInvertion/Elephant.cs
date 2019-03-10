using SOLIDPresentation_GoodExamples.DependencyInvertion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPresentation_GoodExamples.DependencyInversion
{
    class Elephant : ICleanable
    {
        public void Clean()
        {
            Console.WriteLine("Uses water canon to wash elephant.");
        }
    }
}
