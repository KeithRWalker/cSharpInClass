using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
/*            var strings = new List<string>();
            strings.Add("one");
            strings.Contains("two");*/

            var alphabetWords = new Dictionary<char, string>();
            alphabetWords.Add('a', "Aztec");
            alphabetWords.Add('b', "Babylon");
            alphabetWords.Add('c', "Cataclysm");
            alphabetWords.Add('d', "Dude");
            foreach (var let in alphabetWords)
            {
                Console.WriteLine($"The current Letter is {let}");
            }

            var dee = alphabetWords['d'];
            alphabetWords['d'] = "dog";
            foreach (var alphabetWord in alphabetWords)
            {
                Console.WriteLine($"The current key is {alphabetWord.Key}, and the value is {alphabetWord.Value}");
            }
            //DESTRUCTURING
/*            foreach (var (keys, value) in alphabetWords)
            {
                Console.WriteLine($"The current key is {alphabetWord.Key}, and the value is {alphabetWord.Value}");
            }*/

            var otherDictionary = new Dictionary<int, string>();
            otherDictionary.Add(1, "One");
            otherDictionary.Add(2, "Two");
            otherDictionary.Add(3, "Three");
            otherDictionary.Add(4, "Four");
            otherDictionary.Add(5, "Five");
            otherDictionary.Add(6, "Six");
            otherDictionary.Add(7, "Seven");

            foreach (var num in otherDictionary)
            {
                Console.WriteLine($"Current Number is {num}");
            }

            var seven = otherDictionary[7];
            Console.WriteLine($"{seven}");
            /*            otherDictionary[7].Replace(666);*/
            otherDictionary[7] = "Changed";
            Console.WriteLine(seven);
            

            var myHashset = new HashSet<Animals>();
            var myAnimal = new Animals { Age = 3, Color = "Black", Name = "Duder", Type = "Dog" };
            var myOtherAnimal = new Animals { Age = 10, Color = "Brown", Name = "Jerry", Type = "Fly" };
            myHashset.Add(myAnimal);
            myHashset.Add(myOtherAnimal);

            var lSDictionary = new Dictionary<int, List<string>>();
            var strings = new List<string>()
            {
                "A string 1",
                "X string 2",
                "A String 3",
                "X String 4",
                "A String 5",
                "X String 6",
            };

            // var results = strings.Contains("string 2");
            // Console.WriteLine($"{results}");


            strings.Add("Added Me");
            var myResult = strings.Contains("Add Me");

            var stringsThatStartWithA = strings
                .Where(currentString => currentString.StartsWith("A"));
            Console.WriteLine("Strings that start with A are...");
            Console.WriteLine($"{stringsThatStartWithA}");

            //

            var firstWordThatStartsWithA = strings
                .First(returnedString => returnedString.StartsWith("A"));
            Console.WriteLine("First String that starts with A is...");
            Console.WriteLine($"{firstWordThatStartsWithA}");
            //

            var secondWordThatStartWithA = strings
                .Skip(1)
                .Take(1);
            Console.WriteLine("Second String that starts with A is...");
            Console.WriteLine($"{secondWordThatStartWithA}");

            //

            var anyWordThatStartsWithX = strings
                .Any(currentWord => currentWord.StartsWith("X"));
            Console.WriteLine("Any String that starts with X is...");
            Console.WriteLine($"{anyWordThatStartsWithX}");
            //

            var allWordsThatStartWithX = strings
                .All(currentWord => currentWord.StartsWith("X"));
            Console.WriteLine("All Strings that starts with X are...");
            Console.WriteLine($"{allWordsThatStartWithX}");

            //

            var firstOrDef = strings
                .FirstOrDefault(currentString => currentString.StartsWith("X"));

            //

            var transformedString = strings.Select(item => $"{item} - transform");

            //

            var transformedAnimals = strings.Select(item => new Animals{Name = item});

            //

            var letteredXAnimals = strings
                .Where(currentSt => currentSt.StartsWith("X"))
                .Select(item => new Animals {Name = item});

            foreach (var an in letteredXAnimals)
            {
                Console.WriteLine($"{an.Name}");
            }

            //

            var groupedStrings = strings
                .GroupBy(currentString => currentString.First());
            
            foreach (var grouping in groupedStrings)
            {
                /*NO VALUE*/
                Console.WriteLine($"Looping over the {grouping.Key} group");
                foreach (var currentString in grouping)
                {
                    Console.WriteLine($"{currentString} is in the {grouping.Key} group");
                }
            }

            //

            var orderByStrings = strings
                .OrderBy(currentString => currentString.Last());
            // OrderByDescending

        }
    }
}
