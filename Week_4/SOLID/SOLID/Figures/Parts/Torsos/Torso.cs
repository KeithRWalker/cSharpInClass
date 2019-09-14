using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Figures.Parts.Torsos
{
    abstract class Torso
    {
        public HandType HandType { get; set; }
        public virtual bool ChestHair => false;
        public int NumberOfArms { get; set; }
        public string Shirt { get; set; }

        public abstract void Flex();
        public abstract void Fight();
    }
}
