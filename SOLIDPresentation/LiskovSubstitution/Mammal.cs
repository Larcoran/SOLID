using SOLIDPresentation.Open_Closed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPresentation.LiskovSubstitution
{
    class Mammal : Animal
    {
        public override void Fly()
        {
            throw new Exception("Mammals can't fly.");
        }

        public override void Swim()
        {
            Console.WriteLine("Dive deep into the water.");
        }

        public override void MakeASound()
        {
            throw new Exception("Makes usual mammal sound.");
        }
    }
}
