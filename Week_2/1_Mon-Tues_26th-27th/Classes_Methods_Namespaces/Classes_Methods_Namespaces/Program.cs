using ClassesMethodsNamespaces.Examples;
using System;
using System.Collections.Generic;

namespace ClassesMethodsNamespaces
{
    internal class Program
    {
        // private string FullName { get; set; } //This is a Property... an Auto Property

        // THIS IS WHAT'S HAPPENING IN THE BACKGROUND
        //private string fullName;
        //void set_FullName(string fullName);
        //{
        //    _fullName = _fullName;
        //}

        static void Main(string[] args)
        {
            Console.WriteLine("PLEASE ENTER YOUR FIRST NAME...");
            var firstInput = Console.ReadLine();
            Console.WriteLine("PLEASE ENTER YOUR LAST NAME...");
            var lastInput = Console.ReadLine();
            Console.WriteLine("PLEASE ENTER YOUR AGE...");
            var userAge = Convert.ToInt32(Console.ReadLine());

            var name = new Name             //You Can Do it this way too
            {                               //var name = new Name();
                FirstName = firstInput,     //name.FirstName = firstInput;
                LastName = lastInput,       //name.LastName = lastInput;
            };
            var fullName = $"{name.FirstName} {name.LastName}";
            var myPerson = new Person(fullName, userAge, 100); // VALUE TYPE This is unique
            var pizza = new Food { Name = "Pizza", Calories = 1100 };


            myPerson.Walk();
            Console.WriteLine("Would you like to eat this pizza? y/n");
            var pizzaResponse = Convert.ToString(Console.ReadLine());

            switch (pizzaResponse)
            {
                case "y":
                    myPerson.Eat(pizza);
                    Console.WriteLine($"{myPerson.Name} devours the {pizza.Name} adding {pizza.Calories} calories to their belly");
                    break;
                case "n":
                    myPerson.Eat("taco", 300);
                    Console.WriteLine("You did not eat the pizza... But You ate Tacos!");
                    break;
                default:
                    Console.WriteLine("Please Enter y/n");
                    break;
            }

            var myCar = new Car(50)
            {
                Color = CarColor.Black,
                TopSpeed = 200,
            };
            Console.WriteLine($"You now have a car! it is a {myCar.Color} Car!");

            Console.WriteLine("Would you like to start your car? y/n");
            var startResponse = Convert.ToString(Console.ReadLine());

            switch (startResponse)
            {
                case "y":
                    myCar.Start(myPerson);
                    break;
                case "n":
                    Console.WriteLine("You did not start the car");
                    break;
                default:
                    Console.WriteLine("Please Enter y/n");
                    break;
            }

            myCar.Accelerate(50);
            myCar.Accelerate(50);
            myCar.Accelerate(50);
            myCar.Accelerate(50);
            myCar.Accelerate(50);
            myCar.Accelerate(50);
            myCar.Accelerate(50);
            myCar.Accelerate(500000);
            var satan  = new Person("Satan", 666, 100);
            var people = new List<Person>();
            people.Add(myPerson);
            people.Add(satan);

            foreach (var person in people)
            {
                person.Eat(pizza);
            }
        }
    }
}
/*  
//myPerson, and otherPerson can't change each other, They are like Identical Twins
//but pointerToMyPerson can change them
// pointerToMyPerson is like a clone
           var otherPerson = new Person(personName, personAge, 200); // VALUE TYPE This is also unique even though the vale is the same
            var pointerToMyPerson = myPerson; // REFERENCE TYPE This is == to myPerson... So It is not unique


            if (myPerson == otherPerson)
            {
                Console.WriteLine("This Wont Happen");
            }

            Console.WriteLine($"otherPerson.Name = {otherPerson.Name}");
            if (myPerson == pointerToMyPerson)
            {
                Console.WriteLine("myPerson.Name = Bob");
                myPerson.Name = "Bob";
            }
            Console.WriteLine("otherPerson = pointerToMyPerson");
            otherPerson = pointerToMyPerson;
            Console.WriteLine($"otherPerson.Name = {otherPerson.Name}");

            if (myPerson == otherPerson && otherPerson == pointerToMyPerson)
            {
                Console.WriteLine("NOW all these things are all the same!");
            }

Console.WriteLine($"{name.FirstName} {name.LastName} please enter The Name of your person");
var personName = Console.ReadLine();
Console.WriteLine($"{name.FirstName} {name.LastName} please enter The Age of your person");
var personAge = Convert.ToInt32(Console.ReadLine());

var userPerson = new Person(fullName, userAge, 7);
            userPerson.Walk();
*/
