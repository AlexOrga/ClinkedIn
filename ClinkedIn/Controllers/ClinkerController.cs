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

        [HttpPost]
        public void Add(Clinker clinker)
        {
            _storage.Add(clinker);
        }
    }
}