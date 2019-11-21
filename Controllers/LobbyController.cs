using Microsoft.AspNetCore.Mvc;
using Hostility_Skirmish.Models;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace Hostility_Skirmish.Controllers
{
    public class TempUser
        {
            public string FirstName;
            public string LastName;
            public TempUser(string f, string l){
                FirstName = f;
                LastName = l;
            } 
        }
    public class LobbyController : Controller
    {
        private MyContext dbContext;
        public LobbyController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet]
        [Route("/lobby")]
        public IActionResult Lobby(){
            string session_email = HttpContext.Session.GetString("Email");
            if ( session_email != null){
                var CurrentUser = dbContext.Users.FirstOrDefault(a => a.Email == session_email);
                CurrentUser.Challenged = false;
                dbContext.SaveChanges();
            }
            List<User> AllUsers = dbContext.Users.Where(x=>x.Logged==true).ToList();
            return View("Lobby", AllUsers);
        }

        [HttpGet]
        [Route("[controller]/{user_id}")] //challenge has been made waiting for acceptance!
        public IActionResult ChallengeDeck(int user_id){
            User ChallengedUser = dbContext.Users.FirstOrDefault(x=>x.UserId == user_id);
            ChallengedUser.Challenged = true;
            dbContext.SaveChanges();
            return View(ChallengedUser);
        }

        [HttpGet]
        [Route("[controller]/check_challengers")]
        public JsonResult GetChallenger(){
            string session_email = HttpContext.Session.GetString("Email");
            if ( session_email != null){
                User CurrentUser = dbContext.Users.FirstOrDefault(a => a.Email == session_email);
                User challenger = dbContext.Users.FirstOrDefault(x=>x.Challenged == true && x.UserId != CurrentUser.UserId);
                if (challenger != null){ //whether it's null or not we don't care!
                    return Json(Newtonsoft.Json.JsonConvert.SerializeObject(challenger)); //only one challenge may occour on the server at any given time!
                }else{
                    return Json(Newtonsoft.Json.JsonConvert.SerializeObject(challenger)); //only one challenge may occour on the server at any given time!
                }
            }else{
                return Json(Newtonsoft.Json.JsonConvert.SerializeObject("Sorry!"));
            }
        }
        [HttpGet]
        [Route("[controller]/drop_challenge")]
        public JsonResult DropChallenge(){
            string session_email = HttpContext.Session.GetString("Email");
            if ( session_email != null){
                List<User> challengers = dbContext.Users.Where(x=>x.Challenged==true).ToList();
                foreach(User challenger in challengers){
                    challenger.Challenged = false;
                }
                dbContext.SaveChanges();
            }
            return Json(Newtonsoft.Json.JsonConvert.SerializeObject("Go to lobby!"));
        }

        [HttpGet]
        [Route("[controller]/getlogs")] //returns all logged in users
        public JsonResult LobbyCheck(){
            List<User> AllUsers = dbContext.Users.Where(x=>x.Logged == true).ToList();
            return Json(Newtonsoft.Json.JsonConvert.SerializeObject(AllUsers)); 
        }

        [Produces("application/json")] //for posts I guess?
        [HttpPost]
        [Route("[controller]/send_here")]
        public JsonResult ImHereJsonMe([FromBody] string json){
            return Json("'well_done':well done!");
        }

        // [HttpGet]
        // [Route("[controller]/gettime")]
        // public JsonResult GimieJson()
        // {
        //     TempUser user = new TempUser("Walter", "Morgan");
        //     user.FirstName = DateTime.Now.ToString("ss");
        //     System.Console.WriteLine($"$$$$$$$$$$$$$$$$$$$${user.FirstName}$$$$$$$$$$$$$$$$$$$$");
        //     return Json(Newtonsoft.Json.JsonConvert.SerializeObject(user)); 
        // }
    }
}