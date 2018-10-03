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
            new Clinker()
            {
                Name = "Trevor",
                Nickname = "Lunch-Box",
                Charge = "Aggravated Cafeteria Robbery",
                Wallet = 50,
                SolitaryConfinement = true,
                Services =
                {
                    new Service {Name = "golden showers", Cost = 120, Description = "no explanation needed"},
                    new Service {Name = "shank guard", Cost = 90, Description = "pull his pants down"},
                    new Service {Name = "clean bathrooms", Cost = 15, Description = "clean the toilets with warden's toothbrush"}
                },
                Id = 1
            },
            new Clinker()
            {
                Name = "Jimothy",
                Nickname = "Capone",
                Charge = "Tax Evasion",
                Wallet = 75,
                SolitaryConfinement = false,
                Services =
                {
                    new Service {Name = "shank guard", Cost = 90, Description = "pull his pants down"},
                    new Service {Name = "clean bathrooms", Cost = 15, Description = "clean the toilets with warden's toothbrush"}
                },
                Id = 2
            },
            new Clinker()
            {
                Name = "Doug",
                Nickname = "Queen Pookie",
                Charge = "Murder",
                Wallet = 20,
                SolitaryConfinement = true,
                Services =
                {
                    new Service {Name = "golden showers", Cost = 120, Description = "no explanation needed"},
                    new Service {Name = "shank guard", Cost = 90, Description = "pull his pants down"}
                },
                Id = 3
            },
            new Clinker()
            {
                Name = "John Jacob JingleHeimer",
                Nickname = "Schmitty",
                Charge = "Identity Fraud",
                Wallet = 35,
                SolitaryConfinement = false,
                Services =
                {
                    new Service {Name = "golden showers", Cost = 120, Description = "no explanation needed"},
                    new Service {Name = "clean bathrooms", Cost = 15, Description = "clean the toilets with warden's toothbrush"}
                },
                Id = 4
            },
            new Clinker()
            {
                Name = "Ralph",
                Nickname = "Five Head",
                Charge = "18th DUI",
                Wallet = 10,
                SolitaryConfinement = false,
                Services =
                {
                    new Service {Name = "clean bathrooms", Cost = 15, Description = "clean the toilets with warden's toothbrush"}
                },
                Id = 5
            }
        };

        public List<Clinker> GetClinkers()
        {
            return _allClinkers;
        }

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
