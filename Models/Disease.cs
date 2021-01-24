using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYP.Models
{
    public class Disease
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Cure> Cures { get; set; }
        public ICollection<Diagnosis> Diagnoses { get; set; }
        public ICollection<Precaution> Precautions { get; set; }
        public ICollection<Symptoms> Symptoms { get; set; }

    }
}
