using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Figures.Parts.Legs
{
    abstract class Legs
    {
        public int NumberOfLegs { get; set; }
        public PantLength PantLength { get; set; }
        public bool BareFoot { get; set; }
        public int VerticalLeap { get; set; }
        public Minifigure LegHead { get; set; }


        public void UseLegs(string activity)
        {
            var bareFootOrNot = BareFoot ? "without shoes" : "with shoes";
            var noShortsOrNot = PantLength == PantLength.None ? "Isn't wearing any pants! Call HR!" : $"is wearing some {PantLength}";

            if (NumberOfLegs <= 0)
            {
                Console.WriteLine("She's nubs");
                return;
            }

            Console.WriteLine($"The {NumberOfLegs} legs {activity} {bareFootOrNot} {noShortsOrNot}");
        }


        public virtual void Kick()
        {
            UseLegs("Kicked you");
        }

        public void Walk()
        {
            UseLegs("Walked");
        }
    }
}
