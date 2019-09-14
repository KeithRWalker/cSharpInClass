using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesMethodsNamespaces.Examples
{
    internal class Name
    {
        // get allows you to get/retrieve/use the value of FullName
        // set allows you to set/change the value of FullName
        // You don't need both, but you need at least one
        public string FirstName { get; set; }

        public string LastName { get; set; }

        private int _charCount;

        //public Name()
        //{

        //}
    }
}
