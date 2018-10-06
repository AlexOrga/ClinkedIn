using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClinkedIn.DataAccess;
using ClinkedIn.Models;

namespace ClinkedIn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinkerController : ControllerBase
    {
        public readonly ClinkerStorage _storage;

        public ClinkerController()
        {
            _storage = new ClinkerStorage();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Clinker>> GetAll()
        {
            
            return _storage.GetClinkers();
        }

        [HttpGet("{id}/daysRemaining")]
        public ActionResult<IEnumerable<string>> GetDaysRemaining(int id)
        {
            var clinker = _storage.GetById(id);
            var endDate = clinker.ReleaseDate;
            var startDate = DateTime.Now;

            TimeSpan t = endDate - startDate;
            string countDown = string.Format("{0} Days, {1} Hours, {2} Minutes, {3} Seconds until release", t.Days, t.Hours, t.Minutes, t.Seconds);

            return Ok(countDown);
        }

        [HttpPost]
        public void Add(Clinker clinker)
        {
            _storage.Add(clinker);
        }
    }
}