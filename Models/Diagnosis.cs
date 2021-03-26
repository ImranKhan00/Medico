using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medico.Models
{
    public class Diagnosis
    {
        public int DiagnosisId { get; set; }
        public DateTime Date { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public User User{ get; set; }
        public ICollection<Disease> Diseases { get; set; }
        public ICollection<Symptoms> Symptoms { get; set; }
        public ICollection<Cure> Cures { get; set; }
    }
}
