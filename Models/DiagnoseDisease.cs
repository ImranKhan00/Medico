using FYP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medico.Models
{
    public class DiagnoseDisease
    {
        public int DiagnoseDiseaseId { get; set; }
        public User User { get; set; }
        public Disease Disease { get; set; }
        public Diagnosis Diagnosis { get; set; }
        public string Severity { get; set; }
    }
}
