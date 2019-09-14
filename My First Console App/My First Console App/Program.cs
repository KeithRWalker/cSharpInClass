using System;
using System.Collections.Generic;

namespace My_First_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            string myStringVar;
            myStringVar = " Hello World! ";

            int myIntVar;
            myIntVar = 7;

            decimal myDecimalVar;
            myDecimalVar = 666.666m;

            DateTime myDateTime = new DateTime();

            bool myBool = true;

            var myThing = new { Name = " Keith ", Age = 28, Bday = myDateTime };

            List<string> myStrings = new List<string>();
            myStrings.Add(" String 1");
            myStrings.Add(" String 2");

            Console.WriteLine(myStringVar + myIntVar + myDecimalVar + myDateTime + myBool + myThing + myStrings);
        }
    }
}
