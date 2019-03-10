using SOLIDPresentation.Open_Closed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPresentation.LiskovSubstitution
{
    class Bird : Animal
    {

        public override void Fly()
        {
            Console.WriteLine("soars towards the sun");
        }

        public override void Swim()
        {
            throw new Exception("Birds can't swim");
        }

        public override void MakeASound()
        {
            Console.WriteLine("Bird singing"); 
        }
    }
}
