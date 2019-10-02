using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BranchAndChicken.api.Models
{
    public class Chicken
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid TrainerId { get; set; }
    }
}
