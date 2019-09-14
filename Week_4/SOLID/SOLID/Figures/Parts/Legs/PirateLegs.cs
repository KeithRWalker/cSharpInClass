using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Figures.Parts.Legs
{
    class PirateLegs : Legs
    {
        public PirateLegs()
        {
            NumberOfLegs = 1;
            PantLength = PantLength.Capris;
            VerticalLeap = 2;
        }
    }
}
