using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BranchAndChicken.api.Models;

namespace BranchAndChicken.api.Command
{
    public class UpdateTrainerCommand
    {
        public string Name { get; set; }
        public int YearsOfExp { get; set; }
        public Specialty Specialty { get; set; }
    }
}
