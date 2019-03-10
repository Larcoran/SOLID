using System;
using System.Collections.Generic;

using SOLIDPresentation.LiskovSubstitution;

namespace SOLIDPresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LiskovSubstitutionExample

            List<Animal> animals = new List<Animal>();
            animals.Add(new Mammal());
            animals.Add(new Fish());
            animals.Add(new Bird());

            foreach (var animal in animals)
            {
                animal.Eat();
                //animal.Fly();
            }

            Console.Read();

            #endregion
        }
    }
}