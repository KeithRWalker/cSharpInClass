using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Figures.Parts.Legs
{
    class ZombieLegs: Legs
    {
        public ZombieLegs()
        {
            NumberOfLegs = 0;
            PantLength = PantLength.None;
            VerticalLeap = 0;
            BareFoot = true;
        }
    }
}
