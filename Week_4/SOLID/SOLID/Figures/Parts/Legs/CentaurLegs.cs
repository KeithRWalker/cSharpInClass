using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Figures.Parts.Legs
{
    class CentaurLegs : Legs
    {
        public CentaurLegs()
        {
            NumberOfLegs = 4;
            PantLength = PantLength.None;
            BareFoot = true;
            VerticalLeap = 100;
        }
    }
}
