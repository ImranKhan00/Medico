using Medico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medico.ViewModel
{
    public class DiagnosisViewModel
    {
        public eGender Gender { get; set; } = eGender.Unknown;
        public int Age { get; set; } = 0;
        public List<Symptoms> Symptoms{ get; set; }
        public List<cSymptomQuestion> Questions { get; set; }
        public List<int> Answers { get; set; }
    }

    public enum eGender
    {
        Unknown=0,
        Male=1,
        Female=2
    }
}
