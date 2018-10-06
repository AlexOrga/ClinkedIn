using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClinkedIn.Models;
using ClinkedIn.DataAccess;

namespace ClinkedIn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Clinker>> GetAllByInterests([FromQuery] string searchedInterest)
        {
            var storage = new ClinkerStorage();
            var clinkers = storage.GetClinkers();

            var results = clinkers.Where(clinker => clinker.Interests.Any(interest => interest.Name == searchedInterest));

            return Ok(results);
        }

        [HttpPost("{id}")]
        public IActionResult AddNewInterest(int id, Interest newInterest)
        {
            var storage = new ClinkerStorage();
            var myInterests = storage.GetById(id).Interests;

            myInterests.Add(newInterest);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateInterest(int id, Interest updatedInterest)
        {
            var storage = new ClinkerStorage();
            var myInterests = storage.GetById(id).Interests;

           foreach(Interest interest in myInterests)
            {
                if(interest.Name == updatedInterest.Name)
                {
                    interest.Description = updatedInterest.Description;
                }
            }
            
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteInterest(int id, Interest interest)
        {
            var storage = new ClinkerStorage();
            var clinker = storage.GetById(id);

            foreach(Interest i in clinker.Interests)
            {
                if (i.Name == interest.Name)
                {
                    clinker.Interests.Remove(i);
                    return Ok();
                }
            }

            return NotFound();
        }
    }
}