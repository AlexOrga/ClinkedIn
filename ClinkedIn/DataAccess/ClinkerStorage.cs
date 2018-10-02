using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinkedIn.Models;

namespace ClinkedIn.DataAccess
{
    public class ClinkerStorage
    {
        static List<Clinker> _allClinkers = new List<Clinker>()
        {
            new Clinker() { Name = "Trevor", Nickname = "Lunch-Box", Charge = "Aggravated Cafeteria Robbery", Wallet = 50, SolitaryConfinement = true, Id = 1},
            new Clinker() { Name = "Jimothy", Nickname = "Capone", Charge = "Tax Evasion", Wallet = 75, SolitaryConfinement = false, Id = 2},
            new Clinker() { Name = "Doug", Nickname = "Queen Pookie", Charge = "Murder", Wallet = 20, SolitaryConfinement = true, Id = 3},
            new Clinker() { Name = "John Jacob JingleHeimer", Nickname = "Schmitty", Charge = "Identity Fraud", Wallet = 35, SolitaryConfinement = false, Id = 4},
            new Clinker() { Name = "Ralph", Nickname = "Five Head", Charge = "18th DUI", Wallet = 10, SolitaryConfinement = false, Id = 5}
        };

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
