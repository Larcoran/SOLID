using System;

namespace SOLIDPresentation_GoodExamples.LiskovSubstitution
{
    internal class Fish : Animal,ISwim
    {
        public void Swim()
        {
            Console.WriteLine("Glide with high speed.");
        }
    }
}
