﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYP.Models
{
    public class Diagnosis
    {
        public int DiagnosisId { get; set; }
        public DateTime Date { get; set; }
        public User User{ get; set; }
        public ICollection<Disease> Diseases { get; set; }
    }
}
