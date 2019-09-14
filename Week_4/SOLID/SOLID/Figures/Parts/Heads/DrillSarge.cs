using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Figures.Parts.Heads
{
    class DrillSarge : IShouter
    {
        public void Talk()
        {
            throw new NotFiniteNumberException();
        }

        public void Shout(int numberOfDecimals)
        {
            throw new NotFiniteNumberException();
        }
    }
}
