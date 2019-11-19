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



        [HttpPost]
        public IActionResult Create_Party(BuildParty party){

            //build each character
            Character char_1 = new Character(
                    party.P1_Health, 
                    party.P1_AttackPower, 
                    party.P1_DefensePower);
            Avatar p1_avatar = FH.GetAvatar(party.P1_Avatar);
            char_1.Avatar_Slot[0]=p1_avatar;
            Ability p1_ability = FH.GetAbility(party.P1_Ability);
            char_1.Ability_Slot[0]=p1_ability;
            Item p1_item = FH.GetItem(party.P1_Item);
            char_1.Item_Slot[0]=p1_item;
            dbContext.Characters.Add(char_1);
            dbContext.SaveChanges();

            Character char_2 = new Character(
                    party.P2_Health, 
                    party.P2_AttackPower, 
                    party.P2_DefensePower);
            Avatar p2_avatar = FH.GetAvatar(party.P2_Avatar);
            char_2.Avatar_Slot[0]=p2_avatar;
            Ability p2_ability = FH.GetAbility(party.P2_Ability);
            char_2.Ability_Slot[0]=p2_ability;
            Item p2_item = FH.GetItem(party.P2_Item);
            char_2.Item_Slot[0]=p2_item;
            dbContext.Characters.Add(char_2);
            dbContext.SaveChanges();

            Character char_3 = new Character(
                    party.P3_Health, 
                    party.P3_AttackPower, 
                    party.P3_DefensePower);
            Avatar p3_avatar = FH.GetAvatar(party.P3_Avatar);
            char_3.Avatar_Slot[0]=p3_avatar;
            Ability p3_ability = FH.GetAbility(party.P3_Ability);
            char_3.Ability_Slot[0]=p3_ability;
            Item p3_item = FH.GetItem(party.P3_Item);
            char_3.Item_Slot[0]=p3_item;
            dbContext.Characters.Add(char_3);
            dbContext.SaveChanges();

            Character char_4 = new Character(
                    party.P4_Health, 
                    party.P4_AttackPower, 
                    party.P4_DefensePower);
            Avatar p4_avatar = FH.GetAvatar(party.P4_Avatar);
            char_4.Avatar_Slot[0]=p4_avatar;
            Ability p4_ability = FH.GetAbility(party.P4_Ability);
            char_4.Ability_Slot[0]=p4_ability;
            Item p4_item = FH.GetItem(party.P4_Item);
            char_4.Item_Slot[0]=p4_item;
            dbContext.Characters.Add(char_4);
            dbContext.SaveChanges();

            Character char_5 = new Character(
                    party.P5_Health, 
                    party.P5_AttackPower, 
                    party.P5_DefensePower);
            Avatar p5_avatar = FH.GetAvatar(party.P5_Avatar);
            char_5.Avatar_Slot[0]=p5_avatar;
            Ability p5_ability = FH.GetAbility(party.P5_Ability);
            char_5.Ability_Slot[0]=p5_ability;
            Item p5_item = FH.GetItem(party.P5_Item);
            char_5.Item_Slot[0]=p5_item;
            dbContext.Characters.Add(char_5);
            dbContext.SaveChanges();

            Party party_build = new Party("NameOfParty");
            party_build.Position1[0]=char_1;
            party_build.Position2[0]=char_2;
            party_build.Position3[0]=char_3;
            party_build.Position4[0]=char_4;
            party_build.Position5[0]=char_5;
            
            dbContext.Parties.Add(party_build);
            dbContext.SaveChanges();

            return Redirect("/");
        }

    



    }

}
=======
      

    }

}

