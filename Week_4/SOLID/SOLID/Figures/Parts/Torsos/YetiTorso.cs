using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Figures.Parts.Torsos
{
    class YetiTorso : Torso
    {
        public override bool ChestHair => true;
        public YetiTorso()
        {
            HandType = HandType.None;
            Shirt = "none";
            NumberOfArms = 2;
        }

        public override void Flex()
        {
            Console.WriteLine("The Yeti Flexes with no hands");
        }

        public override void Fight()
        {
            Console.WriteLine("The Yeti torso attacks you with his nubs");
        }
    }
}
