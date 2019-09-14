using System;
using System.Collections.Generic;
using System.Text;
using SOLID.Figures;

namespace SOLID.Figures.Parts
{

    abstract class Head : ITalker
    {
        public int NumberOfEyes { get; set; }
        public  string EyeColor { get; set; }
        public bool HasNose { get; set; }
        public string HairColor { get; set; }
        public bool MouthIsOpen { get; set; }
        //public HeadSize Size { get; protected set; }


        public virtual void Talk()
        {
            MouthIsOpen = true;
            Console.WriteLine("Hello, I am a Head!");
        }

        public abstract void Think();

        public abstract void Shout(int numberOfDecibels);
    }
}
