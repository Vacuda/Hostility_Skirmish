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
                string FirstName = f;
                string LastName = l;
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
            return View("Lobby");
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

        // [HttpGet]
        // [Route("[controller]/getlogs")] //returns all logged in users
        // public JsonResult LobbyCheck()
        // {
        //     List<User> AllUsers = dbContext.Users.Where(x => x.logged=true).ToList();
            
        //     return Json(Newtonsoft.Json.JsonConvert.SerializeObject(AllUsers)); 
        // }
    }
}