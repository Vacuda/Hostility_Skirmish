
using System;
using System.Collections.Generic;
using System.Linq;
using Hostility_Skirmish.Models;
using Hostility_Skirmish.Models.GameClasses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// Other using statements
namespace Hostility_Skirmish.Controllers {
    [Route ("Build")]
    public class BuildController : Controller {
        private MyContext dbContext;
        public BuildController (MyContext context) {
            dbContext = context;
        }
        // ---------------------------------------------
        [HttpGet ("BuildTeam")]
        public IActionResult BuildTeam () {
            return View ("BuildTeamPage");
        }
        [HttpGet ("GamePage")]
        public IActionResult GamePage () {
            return View ("GamePlayPage");
        }

        [HttpPost("Create_Party")]
        public IActionResult Create_Party (BuildParty party) {

        //build dummy gamestate
        if (dbContext.GameStates.FirstOrDefault() == null){
            GameState gamestate = new GameState();
            dbContext.GameStates.Add(gamestate);
            dbContext.SaveChanges();
        }

        //build party
            Party party_build = new Party();
            party_build.PartyName = "NameOfParty";
            party_build.Wins = 0;
            party_build.GameStateId = 1;

        //get userid
            string email = HttpContext.Session.GetString("Email");
            int user_id = dbContext.Users.FirstOrDefault(c=>c.Email == email).UserId;
            party_build.UserId = user_id;

        //save new party
            dbContext.Parties.Add(party_build);
            dbContext.SaveChanges();
            int party_id = dbContext.Parties.Last().PartyId;

        //build each character
            Character char_1 = new Character();
            char_1._Health = party.P1_Health;
            char_1._AttackPower = party.P1_AttackPower;
            char_1._DefensePower = party.P1_DefensePower;
            char_1._Item_Slot = party.P1_Item;
            char_1._Avatar_Image = party.P1_Avatar;
            char_1.Avatar_Name = Avatar.GetAvatar(party.P1_Avatar);
            char_1.Ability_Slot = party.P1_Ability;
            char_1.PartyId = party_id;
            dbContext.Characters.Add(char_1);
            dbContext.SaveChanges();

            Character char_2 = new Character();
            char_2._Health = party.P2_Health;
            char_2._AttackPower = party.P2_AttackPower;
            char_2._DefensePower = party.P2_DefensePower;
            char_2._Item_Slot = party.P2_Item;
            char_2._Avatar_Image = party.P2_Avatar;
            char_2.Avatar_Name = Avatar.GetAvatar(party.P2_Avatar);
            char_2.Ability_Slot = party.P2_Ability;
            char_2.PartyId = party_id;
            dbContext.Characters.Add(char_2);
            dbContext.SaveChanges();


            Character char_3 = new Character();
            char_3._Health = party.P3_Health;
            char_3._AttackPower = party.P3_AttackPower;
            char_3._DefensePower = party.P3_DefensePower;
            char_3._Item_Slot = party.P3_Item;
            char_3._Avatar_Image = party.P3_Avatar;
            char_3.Avatar_Name = Avatar.GetAvatar(party.P3_Avatar);
            char_3.Ability_Slot = party.P3_Ability;
            char_3.PartyId = party_id;
            dbContext.Characters.Add(char_3);
            dbContext.SaveChanges();


            Character char_4 = new Character();
            char_4._Health = party.P4_Health;
            char_4._AttackPower = party.P4_AttackPower;
            char_4._DefensePower = party.P4_DefensePower;
            char_4._Item_Slot = party.P4_Item;
            char_4._Avatar_Image = party.P4_Avatar;
            char_4.Avatar_Name = Avatar.GetAvatar(party.P4_Avatar);
            char_4.Ability_Slot = party.P4_Ability;
            char_4.PartyId = party_id;
            dbContext.Characters.Add(char_4);
            dbContext.SaveChanges();


            Character char_5 = new Character();
            char_5._Health = party.P5_Health;
            char_5._AttackPower = party.P5_AttackPower;
            char_5._DefensePower = party.P5_DefensePower;
            char_5._Item_Slot = party.P5_Item;
            char_5._Avatar_Image = party.P5_Avatar;
            char_5.Avatar_Name = Avatar.GetAvatar(party.P5_Avatar);
            char_5.Ability_Slot = party.P5_Ability;
            char_5.PartyId = party_id;
            dbContext.Characters.Add(char_5);
            dbContext.SaveChanges();


        //Save Party
            dbContext.SaveChanges();

            return RedirectToAction("BuildTeam");
        }

    }
}


