using System;
using System.Collections.Generic;
using System.Text;
using SOLID.Figures;

namespace SOLID.Figures.Parts
{
    class YodaHead : Head
    {
        public bool HasEars { get; private set; } //can do public bool HasEars => true; instead

        public YodaHead()
        {
            Size = HeadSize.Small;
            HasEars = true;
        }

        public override void Talk()
        {
            Console.WriteLine("Talking Head am I!");
        }

        public override void Think()
        {
            Console.WriteLine("THINKING AM I");
        }

        public void Battle()
        {
            HasEars = false;
            Console.WriteLine("Ears I have not");
        }

    }
}
