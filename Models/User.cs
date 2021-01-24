using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYP.Models
{
    public class User :IdentityUser
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string Contact { get; set; }
    }
}
