using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BranchAndChicken.api.Models;

namespace BranchAndChicken.api.DataAccess
{
    public class ChickenRepository
    {
        private static List<Chicken> _chickens = new List<Chicken>
        {
            new Chicken()
            {
                Id = new Guid(),
                Name = "Chicken A",
                TrainerId = new TrainerRepository().Get("Martin").Id
            },
            new Chicken()
            {
                Id = new Guid(),
                Name = "Chicken B",
            },
            new Chicken()
            {
                Id = new Guid(),
                Name = "Chicken C",
            },
        };

        public List<Chicken>GetAll()
        {
            return _chickens;
        }
    }
}
