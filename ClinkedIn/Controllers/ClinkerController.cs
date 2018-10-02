using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClinkedIn.DataAccess;
using ClinkedIn.Models;

<<<<<<< HEAD

=======
>>>>>>> 2310fc716007a3128553b94b168ba080d578bf9f
namespace ClinkedIn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinkerController : ControllerBase
    {
<<<<<<< HEAD

        static List<Clinker> Clinkers;
        static ClinkerController()
        {

=======
        public readonly ClinkerStorage _storage;
        

        public ClinkerController()
        {
            _storage = new ClinkerStorage();
>>>>>>> 2310fc716007a3128553b94b168ba080d578bf9f
        }

        [HttpGet]
        public ActionResult<IEnumerable<Clinker>> GetAll()
        {
<<<<<<< HEAD
            return Clinkers;
        }
        

=======
            return _storage.GetClinkers();
        }
>>>>>>> 2310fc716007a3128553b94b168ba080d578bf9f
    }
}