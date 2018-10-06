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
        [HttpGet]
        public ActionResult<IEnumerable<Clinker>> GetFriend([FromQuery]int friendId)
        {
            var storage = new ClinkerStorage();
            var clinkersFriends = storage.GetById(friendId).Friends;
            List<Clinker> friendsFriends = new List<Clinker>();

            foreach(var friend in clinkersFriends)
            {
                var clinkers = storage.GetClinkers();
                foreach(Clinker clinker in clinkers)
                {
                    if(clinker.Id == friend)
                    {
                       friendsFriends.Add(clinker);
                    }
                }
            }

            return Ok(friendsFriends);
        }

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