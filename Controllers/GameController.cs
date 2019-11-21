using Microsoft.EntityFrameworkCore;
using Hostility_Skirmish.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Hostility_Skirmish.Models.GameClasses;

namespace Hostility_Skirmish.Controllers
{
    public class GameController : Controller
    {
        private MyContext dbContext;
        public GameController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet] //TEAM A
        [Route("[controller]/{user_id}")] //challenge has been made waiting for acceptance!
        public IActionResult ChallengeDeck(int user_id){
            string session_email = HttpContext.Session.GetString("Email");
            if ( session_email != null){
                var CurrentUser = dbContext.Users.FirstOrDefault(a => a.Email == session_email);
                CurrentUser.Challenged = true;
            }
            User ChallengedUser = dbContext.Users.FirstOrDefault(x=>x.UserId == user_id);
            ChallengedUser.Challenged = true;
            dbContext.SaveChanges();

            //find users
                User UserA = dbContext.Users.FirstOrDefault(a => a.Email == session_email);
                User UserB = dbContext.Users.FirstOrDefault(x=>x.UserId == user_id);

            //find parties
            Party partyA = dbContext.Parties.FirstOrDefault(e=>e.UserId == UserA.UserId);
            Party partyB = dbContext.Parties.FirstOrDefault(e=>e.UserId == UserB.UserId);

            //build gamestate
            GameState gamestate = new GameState();
            gamestate.Parties.Add(partyA);
            gamestate.Parties.Add(partyB);
            gamestate.CurrentTeam = "A";
            dbContext.GameStates.Add(gamestate);
            dbContext.SaveChanges();

            //build big object
            GameState context = dbContext.GameStates
                            .Include(e=>e.Parties)
                            .ThenInclude(e=>e.Characters)
                            .Include(e=>e.Parties)
                            .ThenInclude(e=>e.User)
                            .Where(e=>e.Parties[0].PartyId == partyA.PartyId)
                            .Where(e=>e.Parties[1].PartyId == partyB.PartyId)
                            .FirstOrDefault();

            return View("GameStage");
        }

        [HttpGet] //TEAM B
        [Route("[controller]")] //challenger has entered the arena! Let the game begin!
        public IActionResult EnterGame(){

            string session_email = HttpContext.Session.GetString("Email");

            //find users
            User UserA = dbContext.Users.Where(a => a.Challenged == true)
                                        .Where(e=>e.Email != session_email)
                                        .FirstOrDefault();
            User UserB = dbContext.Users.FirstOrDefault(a => a.Email == session_email);

            //find parties
            Party partyA = dbContext.Parties.FirstOrDefault(e=>e.UserId == UserA.UserId);
            Party partyB = dbContext.Parties.FirstOrDefault(e=>e.UserId == UserB.UserId);

            //build big object
            GameState context = dbContext.GameStates
                                .Include(e=>e.Parties)
                                .ThenInclude(e=>e.Characters)
                                .Include(e=>e.Parties)
                                .ThenInclude(e=>e.User)
                                .Where(e=>e.Parties[0].PartyId == partyA.PartyId)
                                .Where(e=>e.Parties[1].PartyId == partyB.PartyId)
                                .FirstOrDefault();

            //unchallenge user field
            if ( session_email != null){
                List<User> ChallengedUsers = dbContext.Users.Where(a => a.Challenged == true).ToList();
                foreach(User user in ChallengedUsers){
                    user.Challenged = false;
                    dbContext.SaveChanges();
                }
            }

            return View("GameStage", context);
        }
        //read game state whose turn is it? default user1's turn.

        [HttpGet]
        [Route("[controller]/get")]
        public JsonResult GetGameState(){
            return Json("PLACEHOLDER");
        }

        [HttpPost]
        [Route("[controller]/character_action")]
        public JsonResult UserOneCharacterAction([FromBody] string ActionTarget){
            //Team          (A or B)
            //Character     (1,2,3,4,5)
            //Action        (attack, defend, ability, item)
            //Target        (A1,A2,A3,A4,A5,B1,B2,B3,B4,B5)
            //ParseFromString();

            return Json("PLACEHOLDER!!!!");
        }
        //user1 turn
        //wait on user1 character/action/target
        //affect database
        //character turn taken
        //switch turn bool.

        //user2 turn
        //wait on user2 character/action/target
        //affect database
        //character turn taken
        //switch turn bool.

        //if all characters dead or turn taken -> reset turn taken

        //if all user1 characters dead user1 -> user1 lose
        //if all user2 characters dead user2 -> user2 lose
    }
}