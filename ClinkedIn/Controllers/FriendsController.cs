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
        public IActionResult AddFriend( int id, [FromQuery] int friendId)
        {
            var storage = new ClinkerStorage();
            var myInfo = storage.GetById(id);
            var friendInfo = storage.GetById(friendId);

            if (friendInfo == null)
            {
                return NotFound();
            }
            else if (myInfo.Friends.Contains(friendId))
            {
                myInfo.Enemies.Remove(friendId);
                friendInfo.Enemies.Remove(id);
            }

            if (friendInfo == null) return NotFound();
            friendInfo.Friends.Add(id);
            myInfo.Friends.Add(friendId);
            return Ok();
        }
    }
}