using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using BranchAndChicken.api.Command;
using BranchAndChicken.api.DataAccess;
using BranchAndChicken.api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BranchAndChicken.api.Controllers
{
    [Route("api/trainers")]
    [ApiController]
    public class TrainersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Trainer>> GetAllTrainers()
        {
            var repo = new TrainerRepository();
            return repo.GetAll();
        }

        [HttpGet("{name}")]
        public ActionResult<Trainer> GetByName(string name)
        {
            var repo = new TrainerRepository();
            return repo.Get(name);
        }

        [HttpDelete("{name}")]
        public IActionResult DeleteTrainer(string name)
        {
            var repo = new TrainerRepository();
            repo.Remove(name);

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTrainer(UpdateTrainerCommand updatedTrainerCommand, Guid id)
        {
            //mapping/transforming
            var repo = new TrainerRepository();

            var updatedTrainer = new Trainer
            {
                Name = updatedTrainerCommand.Name,
                YearsOfExp = updatedTrainerCommand.YearsOfExp,
                Specialty = updatedTrainerCommand.Specialty,
            };

            var trainerThatGotUpdated = repo.Update(updatedTrainer, id);

            return Ok(trainerThatGotUpdated);
        }

        [HttpPost]

        public IActionResult CreateTrainer(AddTrainerCommand newTrainerCommand)
        {
            var newTrainer = new Trainer
            {
                Id = Guid.NewGuid(),
                Name = newTrainerCommand.Name,
                YearsOfExp = newTrainerCommand.YearsOfExp,
                Specialty = newTrainerCommand.Specialty,
            };

            var repo = new TrainerRepository();

            var trainerThatGotCreated = repo.Add(newTrainer);

            return Created( $"api/trainers/{trainerThatGotCreated.Name}",trainerThatGotCreated);
        }
    }
}