using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medico.Models
{
    public class cSymptomQuestion
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public Symptoms Symptom { get; set; }
    }
}
