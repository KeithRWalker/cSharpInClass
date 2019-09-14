using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameParser
{
    public class Parser
    {
        public Name ParseName(string nameToParse)
        {
            var splitName = nameToParse.Split(" ");

            var name = new Name
            {
                FirstName = splitName.First(),
                LastName = splitName.Last(),
            };

            return name;

        }
    }

    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
