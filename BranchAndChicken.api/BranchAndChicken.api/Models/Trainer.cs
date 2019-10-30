using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BranchAndChicken.api.Models
{
    public class Trainer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int YearsOfExp { get; set; }
        public Specialty Specialty { get; set; }
        public List<Chicken> Cooper { get; set; }
    }

    public enum Specialty
    {
        Chudo,
        Chousting,
        TaeCluckDoe,
        ChravBacaw,
    }
}
