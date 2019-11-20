using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hostility_Skirmish.Models;

namespace Hostility_Skirmish.Models.GameClasses
{
    public class Party
    {
//FIELDS
        [Key]
        public int PartyId {get;set;}


        public string PartyName {get;set;}


        public int Wins {get;set;}


        public Character[] Position {get;set;} = new Character[5];


//RELATIONSHIPS

        public int UserId {get;set;}


//NAVIGATION

        public User User {get;set;}

        [NotMapped]
        public List<Character> Characters {get;set;}


//DISPLAY



















    }
}