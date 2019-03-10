using SOLIDPresentation_GoodExamples.DependencyInvertion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPresentation_GoodExamples.DependencyInversion
{
    class CleaningStation
    {
        private ICollection<ICleanable> animalsToClean;
        public CleaningStation(ICollection<ICleanable> animalsToClean)
        {
            this.animalsToClean = animalsToClean;
        }

        public void Clean()
        {
            foreach(var animal in animalsToClean)
            {
                animal.Clean();
            }
        }
    }
}
