using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Figures.Parts.Torsos
{
    class PirateTorso : Torso
    {
        public override bool ChestHair => true;

        public PirateTorso(HandType handType)
        {
            Shirt = "Froofy with ruffles";
            HandType = handType;
        }

        public override void Flex()
        {
            Console.WriteLine("The Pirate Torso Flexed Swashbucklingly");
        }

        public override void Fight()
        {
            Console.WriteLine("The Pirate Waves the Sword around!");
        }
    }
}
