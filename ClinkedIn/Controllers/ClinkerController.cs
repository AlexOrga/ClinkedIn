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

        static List<Clinker> Clinkers;
        static ClinkerController()
        {

        }

        [HttpGet]
        public ActionResult<IEnumerable<Clinker>> GetAll()
        {
            return Clinkers;
        }
        

    }
}