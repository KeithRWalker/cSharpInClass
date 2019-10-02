﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStorage.Data
{
    class UserRepository
    {
        static List<User> _users = new List<User>();

        public List<User> GetAll()
        {
            // Get the users from the DB
            return _users;
        }

        public void Add(User userToAdd)
        {
            //add user to DB
            userToAdd.Id = Guid.NewGuid();
            _users.Add(userToAdd);
        }

        public void Remove(User userToRemove)
        {
            //remove the user
            _users.Remove(userToRemove);
        }

        public User Update(Guid userId, string firstName, string lastName)
        {
            //update the user
            //_users.Find();//
            var user = _users.First(x => x.Id == userId);

            user.FirstName = firstName;
            user.LastName = lastName;

            return user;
        }
    }

    internal class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
    }
}
