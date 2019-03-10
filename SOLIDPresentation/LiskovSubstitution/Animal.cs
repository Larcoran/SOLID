using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPresentation.LiskovSubstitution

{
    class Animal
    {
        public int DailyFoodConsumptionInKG;

        public virtual void Eat()
        {
            Console.WriteLine($"Eats {DailyFoodConsumptionInKG} kilos of food");
        }

        public virtual void Fly()
        {
            Console.WriteLine("Flys high to the sky");
        }

        public virtual void Swim()
        {
            Console.WriteLine("Dives deep into water");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Zzzz...");
        }

        public virtual void MakeASound()
        {
            Console.WriteLine("Makes usual animal sound");
        }
    }
}
