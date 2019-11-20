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
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        // ---------------------------------------------
     
        [HttpGet("")]
        public IActionResult Index()
        {            
            return View("Index");
        }
        // [HttpGet("Lobby")]
        // public IActionResult Lobby()
        // {            
        //     return View("Lobby");
        // }

     
       
        [HttpGet("LoginPage")]
        public IActionResult LoginPage()
        {            
            return View("LoginPage");
        }
        // [HttpGet("Success")]
        // public IActionResult Success()
        // {   
        //     if(HttpContext.Session.GetString("Email")==null)
        //     {
        //     return RedirectToAction("Index");
        //     }         
        //     ViewBag.Name = HttpContext.Session.GetString("Name");
        //     ViewBag.Email = HttpContext.Session.GetString("Email");
        //     return View("Success");
        // }
        [HttpGet("LogOut")]
        public IActionResult LogOut()
        {            
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        // ---------------------------------------------

        [HttpPost("Register")]
        public IActionResult Register(User NewUser)
        {            
            if(ModelState.IsValid){
                if(dbContext.Users.Any(u => u.Email == NewUser.Email))
                    {
                        ModelState.AddModelError("Email", "Email already in use!");
                        return View("Index",NewUser);
                    }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                NewUser.Password = Hasher.HashPassword(NewUser, NewUser.Password);
                dbContext.Add(NewUser);
                dbContext.SaveChanges();

                HttpContext.Session.SetString("Name",NewUser.FirstName);
                HttpContext.Session.SetString("Email",NewUser.Email);

                return RedirectToAction("BuildTeamPage","Build");
            }
            return View("Index",NewUser);
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginUser NewLogin)
        {            
            if(ModelState.IsValid){
                var CurrentUser = dbContext.Users.FirstOrDefault(a => a.Email == NewLogin.Email);
                if(CurrentUser == null)
                {
                    ModelState.AddModelError("Email","Invalid Email/Password");
                    return View("LoginPage");
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(NewLogin,CurrentUser.Password,NewLogin.Password);
                if(result == 0)
                {
                    ModelState.AddModelError("Email","Invalid Email/Password");
                    return View("LoginPage");
                }
                HttpContext.Session.SetString("Name",CurrentUser.FirstName);
                HttpContext.Session.SetString("Email",CurrentUser.Email);
                return RedirectToAction("BuildTeamPage","Build");
            }
               return View("LoginPage",NewLogin);
        }
        
        // ---------------------------------------------
    }
 }