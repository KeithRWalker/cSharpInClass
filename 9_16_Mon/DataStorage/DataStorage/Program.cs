using System;
using System.Linq;
using DataStorage.Data;

namespace DataStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            var userRepository = new UserRepository();
            while (true)
            {
                

                Console.WriteLine("Enter First Name...");
                var firstName = Console.ReadLine();

                Console.WriteLine("Enter Last Name...");
                var lastName = Console.ReadLine();

                Console.WriteLine("Enter Password...");
                var password = Console.ReadLine();

                var user = new User()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Password = password,
                };

                userRepository.Add(user);

                Console.WriteLine("Add another user? (y/n)");
                var addAnother = Console.ReadLine().ToLower();

                if (addAnother != "y")
                {
                    break;
                }
            }

            var users = userRepository
                .GetAll()
                .Select(user => $"{user.FirstName} {user.LastName} has a password of {user.Password}");

            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
        }
    }
}
