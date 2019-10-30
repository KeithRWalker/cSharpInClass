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
                    trainers.Add(GetTrainerFromDataReader(dataReader));
                }
                return trainers;
            }
        }

        public Trainer Get(string name)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var cmd = connection.CreateCommand();
                //output deleted
                cmd.CommandText = $@"SELECT *
                                     FROM Trainer
                                     WHERE Trainer.Name = @trainerName";

                cmd.Parameters.AddWithValue("trainerName", name);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return GetTrainerFromDataReader(reader);
                }
            }

            return null;
        }

        public bool Remove(string name)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var cmd = connection.CreateCommand();
                cmd.CommandText = $@"DELETE
                                     FROM Trainer
                                     WHERE Trainer.Name = @trainerName";

                cmd.Parameters.AddWithValue("trainerName", name);

                var result = cmd.ExecuteNonQuery();

                return cmd.ExecuteNonQuery() == 1;
            }
        }


        public Trainer Update(Trainer updatedTrainer, Guid id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var cmd = connection.CreateCommand();
                cmd.CommandText = @"
                            UPDATE [Trainer]
                            SET [Name] = @name,
                                [YearsOfExperience] = @yearsOfExperience,
                                [Specialty] = @specialty
                            OUTPUT INSERTED.*
                             WHERE  id = @id";

                cmd.Parameters.AddWithValue("name", updatedTrainer.Name);
                cmd.Parameters.AddWithValue("yearsOfExperience", updatedTrainer.YearsOfExp);
                cmd.Parameters.AddWithValue("specialty", updatedTrainer.Specialty);
                cmd.Parameters.AddWithValue("id", id);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return GetTrainerFromDataReader(reader);
                }

                return null;
            }
        }

        public Trainer Add(Trainer newTrainer)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var cmd = connection.CreateCommand();
                cmd.CommandText = @"INSERT INTO [Trainer]
                                   ([Id]
                                   ,[Name]
                                   ,[YearsOfExperience]
                                   ,[Specialty])
                                OUTPUT INSERTED.*
                                VALUES
                                   (@id
                                   ,@name
                                   ,@yearsOfExperience
                                   ,@specialty)";

                cmd.Parameters.AddWithValue("id", newTrainer.Id);
                cmd.Parameters.AddWithValue("name", newTrainer.Name);
                cmd.Parameters.AddWithValue("yearsOfExperience", newTrainer.YearsOfExp);
                cmd.Parameters.AddWithValue("specialty", newTrainer.Specialty);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return GetTrainerFromDataReader(reader);
                }

                return null;
            }
        }


        Trainer GetTrainerFromDataReader(SqlDataReader reader)
        {
            //explicit cast
            var id = (Guid)reader["Id"];
            //implicit cast
            var name = reader["name"] as string;
            //convert to
            var yearsOfExperience = Convert.ToInt32(reader["YearsOfExperience"]);
            //try parse
            if (Enum.TryParse<Specialty>(reader["specialty"].ToString(), out var specialty))
            {
                //do something
            }

            var trainer = new Trainer
            {
                Specialty = specialty,
                Id = id,
                Name = name,
                YearsOfExp = yearsOfExperience
            };

            return trainer;
        }
    }
}
