using System;

namespace SOLIDPresentation_GoodExamples.LiskovSubstitution

{
    class Animal
    {
        public int DailyFoodConsumptionInKG;

        public virtual void Eat()
        {
            Console.WriteLine($"Eats {DailyFoodConsumptionInKG} kilos of food");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Zzzz...");
        }
    }
}
