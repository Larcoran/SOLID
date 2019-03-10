using System;

namespace SOLIDPresentation_GoodExamples.LiskovSubstitution
{
    class Mammal : Animal, ISwim,IMakeASound
    {

        public  void Swim()
        {
            Console.WriteLine("Dives deep into the water.");
        }

        public  void MakeASound()
        {
            throw new Exception("Makes usual mammal sound.");
        }
    }
}