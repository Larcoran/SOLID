using SOLIDPresentation.Open_Closed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPresentation.LiskovSubstitution
{
    class Fish : Animal
    {

        public override void Fly()
        {
            throw new Exception("Fish can't fly.");
        }

        public override void Swim()
        {
            Console.WriteLine("Glide with high speed.");
        }

        public override void MakeASound()
        {
            throw new Exception("Fish can't make a sound.");
        }
    }
}
