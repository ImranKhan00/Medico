using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medico.Models
{
    public class Cure
    {
        public int CureId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Disease> Diseases { get; set; }
    }
}
