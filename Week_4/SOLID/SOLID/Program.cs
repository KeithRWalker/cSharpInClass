using System;
using System.Collections.Generic;
using SOLID.Figures;
using SOLID.Figures;
using SOLID.Figures.Parts;
using SOLID.Figures.Parts.Legs;
using SOLID.Figures.Parts.Torsos;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            var myHead = new FatHead();
            var myTorso = new YetiTorso();

            var myLegs = new CentaurLegs();

            var myFigure = new Minifigure(myHead, myTorso, myLegs);

            myFigure.Battle();

            var yodaHead = new YodaHead()
            {
                EyeColor = "Green",
                HairColor = "White",
                HasNose = true,
                MouthIsOpen = false,
                NumberOfEyes = 2,
            };
            var yodaLegs = new PirateLegs();
            var yodaTorso = new YetiTorso();
            var yoda = new Minifigure(yodaHead, yodaTorso, yodaLegs);

            yoda.Battle();

            var fatheadDrill = new Minifigure();

                var talkers = new List<ITalker>() { };
            // foreach (var talker in talkers)
            // {
            //  talkers.Talk();
            // }


            //
            {
                /*
                var yoda = new Minifigure();
                var fatHead = new FatHead();
    
                fatHead.Talk();
                yoda.Head.Talk();
    
                // yoda.Head.Battle();
    
                fatHead.Think();
                yoda.Head.Think();
    
                var vadar = new DarthVadarHead();
    
                vadar.Talk();
    
                var pirate = new PirateTorso(HandType.Hook);
    
                switch (yoda.Head)
                {
                    case YodaHead yodaHead:
                        yodaHead.Battle();
                        break;
                }
    
                
                torso.Fight();
                torso.Flex();
                */
            }
        }
    }
}