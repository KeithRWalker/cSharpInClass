using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Figures.Parts
{
    class FatHead : Head
    {
        public FatHead()
        {
            Size = HeadSize.Fat;
        }

        public void Deflate()
        {
            Size = HeadSize.Small;
        }

        public override void Talk()
        {
            MouthIsOpen = true;
            Console.WriteLine("Hello I am a fat head");
        }

        public override void Think()
        {
            Console.WriteLine("I wish i wasn't such a fat head");
        }
    }
}
