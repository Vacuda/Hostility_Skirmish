using Microsoft.EntityFrameworkCore;
using Hostility_Skirmish.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace Hostility_Skirmish.Controllers
{
    public class GameController : Controller
    {
        private MyContext dbContext;
        public GameController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet]
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
            return View("GameStage");
        }

        [HttpGet]
        [Route("[controller]")] //challenger has entered the arena! Let the game begin!
        public IActionResult EnterGame(){
            string session_email = HttpContext.Session.GetString("Email");
            if ( session_email != null){
                List<User> ChallengedUsers = dbContext.Users.Where(a => a.Challenged == true).ToList();
                foreach(User user in ChallengedUsers){
                    user.Challenged = false;
                    dbContext.SaveChanges();
                }
            }
            return View("GameStage");
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