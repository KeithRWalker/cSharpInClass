using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using BranchAndChicken.api.Models;
using Microsoft.AspNetCore.Mvc;

namespace BranchAndChicken.api.DataAccess
{
    public class TrainerRepository
    {
        /*        private static List<Trainer> _trainers = new List<Trainer>
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
                };*/

        private readonly List<Trainer> _trainers = new List<Trainer>();

        private readonly string _connectionString = "Server=localhost;Database=BranchAndChicken;Trusted_Connection=True;";

        public List<Trainer> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM Trainer";
                var dataReader = cmd.ExecuteReader();
                var trainers = new List<Trainer>();
                while (dataReader.Read())
                {
                    /*  Explicit Cast   */
                    var id = (Guid) dataReader["Id"];
                    /*  Implicit Cast   */
                    var name = dataReader["Name"] as string;
                    /*  Convert To   */
                    var yearsOfExperience = Convert.ToInt32(dataReader["YearsOfExperience"]);
                    /*  Try Parse   */
                    Enum.TryParse<Specialty>(dataReader["Specialty"].ToString(), out var specialty);
                    var trainer = new Trainer
                    {
                        Specialty = specialty,
                        Id = id,
                        Name = name,
                        YearsOfExp = yearsOfExperience
                    };
                    trainers.Add(trainer);
                }
                return trainers;
            }
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

/*        public ActionResult<Trainer> GetSpecialty(string specialty)
        {
            throw new NotImplementedException();
        }*/

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
