using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesMethodsNamespaces.Examples
{
    internal class Person
    {
/*        //private string _name;

        //public string OtherName
        //{
        //    get { return _name; }
        //    set { _name = $"{value} was your answer, but it's not anymore"; }
        //}

        // get => "";
        // set => "";*/


        // Properties
        public string Name { get; set;}
        public int Age { get; set; }

        // Fields
        readonly int _speed;
        List<string> _foodInMyBelly = new List<string>();
        int _caloricIntake;

        private const int MaxWalkingSpeed = 10;

        // Constructor Method
        public Person(string name, int age, int speed) // We Insert The Values of the properties here
        {
            Name = name; //shouldn't have to use .this for these
            Age = age;
            _speed = speed;
        }

        public void Walk()
        {
            if (_speed < MaxWalkingSpeed)
            {
                Console.WriteLine($"{Name} is walking at {_speed} feet per second.");
            }
            else
            {
                Console.WriteLine("Slowdown you hooligan!");
            }
        }

        public void Eat(string name, int calories)
        {
            if (_caloricIntake > 2500)
            {
                Console.WriteLine("You may not eat more food.");
                return;
            }

            _foodInMyBelly.Add(name);
            _caloricIntake += calories;
        }

        public void Eat(Food food) //Type name, Food food, 
        {
            Eat(food.Name, food.Calories);
        }
    }
}
