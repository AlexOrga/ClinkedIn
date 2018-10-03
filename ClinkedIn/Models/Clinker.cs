using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.Models
{
    public class Clinker
    {
        public string Name { get; set; }
        public string Nickname { get; set; }
        public List<Service> Services { get; set; } = new List<Service>();
        public string Charge { get; set; }
        public int Wallet { get; set; }
        public bool SolitaryConfinement { get; set; }
        public int Id { get; set; }
    }
}
