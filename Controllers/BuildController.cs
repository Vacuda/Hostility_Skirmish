using Microsoft.EntityFrameworkCore;
using Hostility_Skirmish.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
// Other using statements
namespace Hostility_Skirmish.Controllers
{
    [Route("Build")]
    public class BuildController : Controller
    {
        private MyContext dbContext;
        public BuildController(MyContext context)
        {
            dbContext = context;
        }
        // ---------------------------------------------
        [HttpGet("BuildTeam")]
        public IActionResult BuildTeam()
        {            
            return View("BuildTeamPage");
        }
      

    }

}