using System;
using System.Collections.Generic;
using System.Text;
using SOLID.Figures;
using SOLID.Figures.Parts;
using SOLID.Figures.Parts.Legs;
using SOLID.Figures.Parts.Torsos;

namespace SOLID.Figures
{
    class Minifigure
    {
         readonly ITalker _talker;
         readonly Torso _torso;
         readonly Legs _legs;

        public Minifigure(ITalker talker, Torso torso, Legs legs)
        {
            _talker = talker;
            _torso = torso;
            _legs = legs;
        }


        public void Battle()
        {
            _legs.Walk();
            _talker.Talk();
            _torso.Flex();
            _torso.Fight();
            _legs.Kick();
        }
    }
}
