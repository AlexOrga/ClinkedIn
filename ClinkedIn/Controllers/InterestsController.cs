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
    }
}