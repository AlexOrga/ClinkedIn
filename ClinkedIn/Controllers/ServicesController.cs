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

            var results = allClinkers.Where(clinker => clinker.Services.Any(s => s.Name == searchedService));

            return Ok(results);
        }

        [HttpPost("{id}/services")]
        public IActionResult PostNewService(int id, Service newService)
        {
            var storage = new ClinkerStorage();
            var myService = storage.GetById(id).Services;

            myService.Add(newService);

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateService(int id, Service updateService)
        {
            var storage = new ClinkerStorage();
            var serviceUpdate = storage.GetById(id).Services;
            foreach (Service service in serviceUpdate)
            {
                if (service.Name == updateService.Name)
                {
                    service.Cost = updateService.Cost;
                    service.Description = updateService.Description;

                }       
            }
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id, Service deleteService)
        {
            var storage = new ClinkerStorage();
            var allRecords = storage.GetById(id).Services;
            var serviceRecordsToKeep = new List<Service>();
            foreach (Service service in allRecords)
            {
                if (service.Name != deleteService.Name)
                {
                    serviceRecordsToKeep.Add(service);
                }
            }
            storage.GetById(id).Services = serviceRecordsToKeep;
                return Ok();
        }
    }
}