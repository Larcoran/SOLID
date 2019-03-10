using SOLIDPresentation_GoodExamples.DependencyInvertion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPresentation_GoodExamples.DependencyInversion
{
    class Snake : ICleanable
    {
        public void Clean()
        {
            Console.WriteLine("Puts snake into sink half-full of warm water and cleans with soft sponge.");
        }
    }
}
