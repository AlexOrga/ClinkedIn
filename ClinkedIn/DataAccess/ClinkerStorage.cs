using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinkedIn.Models;

namespace ClinkedIn.DataAccess
{
    public class ClinkerStorage
    {
        static List<Clinker> _allClinkers = new List<Clinker>();
        
        public void Add(Clinker clinker)
        {
            clinker.Id = _allClinkers.Any() ? _allClinkers.Max(x => x.Id) + 1 : 1;
            _allClinkers.Add(clinker);
        }

        public Clinker GetById(int id)
        {
            return _allClinkers.First(clinker => clinker.Id == id);
        }
    }
}
