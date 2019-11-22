using Microsoft.EntityFrameworkCore;
using Hostility_Skirmish.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Hostility_Skirmish.Models.GameClasses;
using System;

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
            Party partyA = dbContext.Parties
                                .Include(e=>e.Characters)
                                .FirstOrDefault(e=>e.UserId == UserA.UserId);
            Party partyB = dbContext.Parties
                                .Include(e=>e.Characters)
                                .FirstOrDefault(e=>e.UserId == UserB.UserId);


            //reset parties
            partyA.Reset();
            partyB.Reset();

            //Assign client's team
            ViewBag.PlayerTeam = "A";

            //build gamestate
            GameState gamestate = new GameState();
            gamestate.CurrentTeam = "A";
            
            dbContext.GameStates.Add(gamestate);
            dbContext.SaveChanges();

            //change gamestateid on both parties.  Needs to be in this order.
            int gamestate_id = dbContext.GameStates.Last().GameStateId;
            partyA.GameStateId = gamestate_id;
            dbContext.SaveChanges();
            partyB.GameStateId = gamestate_id;
            dbContext.SaveChanges();

            //Send to HTML DOM for later use by javascript.
            ViewBag.gamestate_id = gamestate_id;

            //build big object
            GameState context = dbContext.GameStates
                            .Include(e=>e.Parties)
                            .ThenInclude(e=>e.Characters)
                            .Include(e=>e.Parties)
                            .ThenInclude(e=>e.User)
                            .FirstOrDefault(e=>e.GameStateId == gamestate_id);

            return View("../Build/GamePlayPage", context);
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
            System.Console.WriteLine($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@{partyA.PartyId}@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            System.Console.WriteLine($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@{partyB.PartyId}@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");

            //build big object
            GameState context = dbContext.GameStates
                                .Include(e=>e.Parties)
                                .ThenInclude(e=>e.Characters)
                                .Include(e=>e.Parties)
                                .ThenInclude(e=>e.User)
                                .FirstOrDefault(e=>e.GameStateId == partyA.GameStateId);

            //Assign client's team
            ViewBag.PlayerTeam = "B";
            //Send to HTML DOM for later use by javascript.
            ViewBag.gamestate_id = partyA.GameStateId;

            //unchallenge user field
            if ( session_email != null){
                List<User> ChallengedUsers = dbContext.Users.Where(a => a.Challenged == true).ToList();
                foreach(User user in ChallengedUsers){
                    user.Challenged = false;
                    dbContext.SaveChanges();
                }
            }

            return View("../Build/GamePlayPage", context);
        }
        //read game state whose turn is it? default A's turn.

        [HttpGet] //send json to javascript
        [Route("[controller]/getstate/{gamestate_id}")]
        public JsonResult GetGameState(int gamestate_id){
            //int gamestate_id = Int32.Parse(gamestate_id_string);
            System.Console.WriteLine($"&&&&&&&&&&&&&&&&&&&&&&{gamestate_id}&&&&&&&&&&&&&&&&&&&");
            GameState context = dbContext.GameStates
                            .Include(e=>e.Parties)
                            .ThenInclude(e=>e.Characters)
                            .FirstOrDefault(e=>e.GameStateId == gamestate_id);
            System.Console.WriteLine($"&&&&&&&&&&&&&&&&&&&&&&{context.Parties[0].Characters[0].IsAlive}&&&&&&&&&&&&&&&&&&&");
            return Json(Newtonsoft.Json.JsonConvert.SerializeObject(context));
        }

        [Produces("application/json")] //for posts I guess?
        [HttpPost]
        [Route("[controller]/character_action/{gamestate_id}")]
        public JsonResult UserOneCharacterAction([FromBody] string ActionTarget, int gamestate_id ){
          //Team          (A or B)
            //Character     (1,2,3,4,5)
            //Action        (attack, defend, ability, item)
            //Target        (A1,A2,A3,A4,A5,B1,B2,B3,B4,B5)

        //just to be safe
        System.Console.WriteLine($"$$$$$$$$$$$$$$$$${gamestate_id}$$$$$$$$$$$$$$$$$$");    

        //parse string
            string Team = "XXX";
            int break1 = 0;
            string Character = "XXX";
            int break2 = 0;
            string Action = "XXX";
            int break3 = 0;
            string Target = "XXX";
            int counter = 0;

            for(var x=0; x<ActionTarget.Length; x++){
                string cursor = "" + ActionTarget[x]; //make char a string you monsterous language

                if(cursor == ":" && break3 == 0 && break2 != 0 && break1 != 0){ //action
                    System.Console.WriteLine($"Break3: {x}");
                    break3 = x;
                    Action = ActionTarget.Substring(break2 + 1, counter-1);
                    Target = ActionTarget.Substring(break3+1); //target
                    counter = 0;
                }
                
                if(cursor == ":" && break1 != 0 && break2 == 0 && break3 == 0){ //character
                    System.Console.WriteLine($"Break2: {x}");
                    Character = ActionTarget.Substring(break1 + 1, counter-1);
                    counter = 0;
                    break2 = x;
                }

                if(cursor == (string)":" && break1 == 0 && break2 == 0 && break3 == 0){ //team
                    System.Console.WriteLine($"Break1: {x}");
                    counter = 0;
                    break1 = x;
                    Team = ActionTarget.Substring(0, break1);
                }
                counter += 1;
                System.Console.WriteLine("#########################################");
            }
            System.Console.WriteLine($"{Team} {Character} {Action} {Target}");
            //perform action
                GameState gamestate = dbContext.GameStates
                            .Include(e=>e.Parties)
                            .ThenInclude(e=>e.Characters)
                            .FirstOrDefault(e=>e.GameStateId == gamestate_id);
                if(Team == gamestate.CurrentTeam){
                    if(Target[0]+"" == "A"+""){ //wow c#
                        Ability.AbilityUse(gamestate.Parties[0].Characters[Int32.Parse(Target[1]+"")], Action);
                    }else{ //Team == "B"
                        Ability.AbilityUse(gamestate.Parties[1].Characters[Int32.Parse(Character)], Action);
                    }
                    System.Console.WriteLine($"TURN {Team} TAKEN");
                     
                    if(gamestate.CurrentTeam == "A"){ 
                        //player's character loses a turn
                        gamestate.Parties[0].Characters[Int32.Parse(Character)].TurnTaken = true;
                        //switch turn
                        gamestate.CurrentTeam="B";
                    }
                    if(gamestate.CurrentTeam == "B"){
                        gamestate.Parties[1].Characters[Int32.Parse(Character)].TurnTaken = true;
                        gamestate.CurrentTeam="A";
                    }
                    dbContext.SaveChanges();
                }//else nothing happens

                //reset all TurnTaken bools if all are true.
            return Json(Newtonsoft.Json.JsonConvert.SerializeObject($"{Team} {Character} {Action} {Target}"));
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