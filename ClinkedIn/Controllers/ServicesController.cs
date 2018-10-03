using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinkedIn.DataAccess;
using ClinkedIn.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinkedIn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Clinker>> GetByServices([FromQuery]string searchedService)
        {
            var _storage = new ClinkerStorage();
            var allClinkers = _storage.GetClinkers();

            var results = allClinkers.Where(clinker => clinker.Services.Any(s=> s.Name == searchedService));

            return Ok(results);
        }
    }
}