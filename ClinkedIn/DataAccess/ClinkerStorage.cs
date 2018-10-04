using System.Collections.Generic;
using System.Linq;
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
                    new Service {Name = "clean", Cost = 15, Description = "i need to see my reflection"}
                },
                Interests =
                {
                    new Interest {Name = "Cards", Description = "Playing cards you idiot"},
                },
                Friends = {2,3,4 },
                
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
                Interests =
                {
                    new Interest {Name = "Making trashbag necklaces", Description = "Twisting up trash bags until they become prison jewelry"},
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
                Interests =
                {
                    new Interest {Name = "Making wine", Description = "Taking all the fruit from a confidant in the cafeteria and leaving them in the toilet of a cell until they ferment into the worst wine you've ever had."},
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
                Interests =
                {
                    new Interest {Name = "Working out", Description = "Gotta get big if you wanna run the yard."},
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
                Interests =
                {
                    new Interest {Name = "Cards", Description = "Playing cards you idiot"},
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

        public void AddFriend(int id)
        {
            var selectedClinker = _allClinkers.Where(clinker => clinker.Id == id);
            //_allClinkers
        }
    }
}
