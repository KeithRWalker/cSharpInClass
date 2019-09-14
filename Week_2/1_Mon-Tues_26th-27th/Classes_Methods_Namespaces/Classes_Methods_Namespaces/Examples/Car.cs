using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesMethodsNamespaces.Examples
{
    enum CarColor
    {
        Black,
        Blue,
        Red,
        Yellow,
        Green,
        White
    }

    class Car
    {
        public CarColor Color { get; set; }
        public int TopSpeed { get; set; }
        public bool IsInsured { get; set; }

        private decimal _gasLevel;
        private bool _isRunning;
        private Person _driver;
        private int _currentSpeed;
        private const decimal GasToStart = .5m;

        public Car(decimal gasLevel)
        {
            _gasLevel = gasLevel;
        }

        public void Start(Person driver)
        {
            if (_gasLevel > GasToStart)
            {
                _isRunning = true;
                _driver = driver;
                _gasLevel -= GasToStart;
                Console.WriteLine($"Car has been started by {driver.Name} your gas level is {_gasLevel}");
            }
            else
            {
                Console.WriteLine($"{driver.Name} You're out of gas!");
            }
        }

        public void Accelerate(int howMuchFaster)
        {
            if (!_isRunning)
            {
                Console.WriteLine("Car is not running, Can't Accelerate....");
                return;
            }
            if (_gasLevel <= 0)
            {
                _isRunning = false;
                Console.WriteLine("You ran out of gas foo");
            }

            if (_currentSpeed < TopSpeed && _currentSpeed + howMuchFaster < TopSpeed)
            {
                _currentSpeed += howMuchFaster;
                _gasLevel -= 10;
                Console.WriteLine($"You have accelerated by {howMuchFaster}mph, your current speed is {_currentSpeed}");
                return;
            }
            Console.WriteLine($"You have reached Maximum speed of {_currentSpeed}");

        }

        //public = Access Modifier
        //decimal = return modifier
        //refuel = name
        //(decimal amountOfGas) = parameter (Type Name)
        public decimal Refuel(decimal amountOfGas)
        {
            _gasLevel += amountOfGas;
            return _gasLevel;
        }
    }
}
