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
    public class EnemiesController : ControllerBase
    {
        [HttpPut("{id}/enemies")]
        public IActionResult AddEnemy(int id, [FromQuery] int enemyId)
        {
            var storage = new ClinkerStorage();
            var myInfo = storage.GetById(id);
            var enemyInfo = storage.GetById(enemyId);

            if (enemyInfo == null)
            {
                return NotFound();
            }
            else if (myInfo.Friends.Contains(enemyId))
            {
                myInfo.Friends.Remove(enemyId);
                enemyInfo.Friends.Remove(id);
            }

            enemyInfo.Enemies.Add(id);
            myInfo.Enemies.Add(enemyId);
            return Ok();
        }
    }
}