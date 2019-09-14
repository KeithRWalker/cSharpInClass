using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Figures.Parts
{
    class DarthVadarHead : Head
    {

        public override void Talk()
        {
            Console.WriteLine("KOOOOH PUHHHHHRR");
            base.Talk();
            Console.WriteLine("KOOOOH PUHHHHHRR");
        }

        public override void Think()
        {
            Console.WriteLine("I am your father?");
        }
    }
}
