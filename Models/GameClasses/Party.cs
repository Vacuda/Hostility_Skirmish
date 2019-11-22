using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hostility_Skirmish.Models;
using Newtonsoft.Json;

namespace Hostility_Skirmish.Models.GameClasses
{
    public class Party
    {
//FIELDS
        [Key]
        public int PartyId {get;set;}


        public string PartyName {get;set;}


        public int Wins {get;set;}


//RELATIONSHIPS
        public int UserId {get;set;}

        public int GameStateId {get;set;}

//NAVIGATION
        [JsonIgnore]  
        public User User {get;set;}

        [JsonIgnore]
        public GameState GameState {get;set;}


        public List<Character> Characters {get;set;}


//DISPLAY


//METHODS

        public void Reset(){
            foreach(var c in Characters){
                c.Health        = c._Health;
                c.AttackPower   = c._AttackPower;
                c.DefensePower  = c._DefensePower;
                c.Avatar_Image  = c._Avatar_Image;
                c.Item_Slot     = c._Item_Slot;
            }
        }











    }
}