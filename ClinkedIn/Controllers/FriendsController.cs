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

        [HttpPut("{id}/friends")]
        public IActionResult PutFriend([FromQuery] int id, int friendId)
        {
            var storage = new ClinkerStorage();
            var myInfo = storage.GetById(id);
            var friend = storage.GetById(friendId);

            if (friend == null) return NotFound();
            friend.Friends.Add(id);
            myInfo.Friends.Add(friendId);
            return Ok();
        }

        

        
    }
}