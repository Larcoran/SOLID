using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPresentation.DependencyInversion
{
    class CleaningStation
    {
        private Elephant elephant;
        private Snake snake;
        public CleaningStation()
        {
            elephant = new Elephant();
            snake = new Snake();
        }

        public void Clean()
        {
            elephant.Clean();
            snake.Clean();
        }
    }
}
