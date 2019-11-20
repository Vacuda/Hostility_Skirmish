using Microsoft.AspNetCore.Mvc;
using Hostility_Skirmish.Models;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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
            List<User> AllUsers = dbContext.Users.ToList();
            return View("Lobby", AllUsers);
        }

        [HttpGet]
        [Route("[controller]/gettime")]
        public JsonResult GimieJson()
        {
            TempUser user = new TempUser("Walter", "Morgan");
            user.FirstName = DateTime.Now.ToString("ss");
            System.Console.WriteLine($"$$$$$$$$$$$$$$$$$$$${user.FirstName}$$$$$$$$$$$$$$$$$$$$");
            return Json(Newtonsoft.Json.JsonConvert.SerializeObject(user)); 
        }

        [HttpGet]
        [Route("[controller]/getlogs")] //returns all logged in users
        public JsonResult LobbyCheck()
        {
            //List<User> AllUsers = dbContext.Users.Where(x => x.Logged==true).ToList();
            //List<User> AllUsers = dbContext.Users.ToList();
            List<User> AllUsers = dbContext.Users.ToList();
            return Json(Newtonsoft.Json.JsonConvert.SerializeObject(AllUsers)); 
        }

        [Produces("application/json")]
        [HttpPost]
        [Route("[controller]/send_here")]
        public JsonResult ImHereJsonMe([FromBody] string json){
            System.Console.WriteLine($"@@@@@@@@@@@{json}@@@@@@@@@@@@");
            return Json("'well_done':well done!");
        }
    }
}