using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BranchAndChicken.api.Models;
using Microsoft.AspNetCore.Mvc;

namespace BranchAndChicken.api.DataAccess
{
    public class TrainerRepository
    {
        private static List<Trainer> _trainers = new List<Trainer>
        {
            new Trainer()
            {
                Id = Guid.NewGuid(),
                Name = "Martin",
                Specialty = Specialty.TaeCluckDoe,
                YearsOfExp = 0,
            },
            new Trainer()
            {
                Id = Guid.NewGuid(),
                Name = "Nathan",
                Specialty = Specialty.Chudo,
                YearsOfExp = 12,
            },
            new Trainer()
            {
                Id = Guid.NewGuid(),
                Name = "Adam",
                Specialty = Specialty.ChravBacaw,
                YearsOfExp = 3,
            }
        };

        public List<Trainer> GetAll()
        {
            return _trainers;
        }

        public Trainer Get(string name)
        {
            var trainer = _trainers.First(t => t.Name == name);
            return trainer;
        }

        public void Remove(string name)
        {
            var trainer = Get(name);
            _trainers.Remove(trainer);
        }

        public ActionResult<Trainer> GetSpecialty(string specialty)
        {
            throw new NotImplementedException();
        }

        public Trainer Update(Trainer updatedTrainer, Guid id)
        {
            var trainerToUpdate = _trainers.First(trainer => trainer.Id == id);

            trainerToUpdate.Name = updatedTrainer.Name;
            trainerToUpdate.YearsOfExp = updatedTrainer.YearsOfExp;
            trainerToUpdate.Specialty = updatedTrainer.Specialty;

            return trainerToUpdate;
        }

        public Trainer Add(Trainer newTrainer)
        {
            _trainers.Add(newTrainer);
            return newTrainer;
        }
    }
}
