using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Figures
{
    interface ITalker
    {
        void Talk();
    }

    interface IShouter : ITalker
    {
        void Shout(int numberOfDecibels);
    }
}
