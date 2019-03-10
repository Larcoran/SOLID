using System;

namespace SOLIDPresentation_GoodExamples.LiskovSubstitution
{
    class Bird : Animal, IFly
    {
        public void Fly()
        {
            Console.WriteLine("Flies high into the sky");
        }
    }
}
