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
    public class FriendsController : ControllerBase
    {
        [HttpPut("{id}/friendId")]
        public IActionResult PutFriend(int id, int friendId)
        {
            var storage = new ClinkerStorage();
            var friend = storage.GetById(id);

            if (friend == null) return NotFound();
            friend.Friends.Add(id);
            return Ok();
        }

        //public ActionResult<IEnumerable<Clinker>> GetById([FromQuery] int searchedId)
        //{
        //}
    }
}