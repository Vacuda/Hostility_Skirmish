using System.ComponentModel.DataAnnotations;

namespace Hostility_Skirmish.Models
{
    public class Party
    {
//FIELDS
        [Key]
        public int PartyId {get;set;}


        public string PartyName {get;set;}


        public int Wins {get;set;}


        public Character[] Position1 {get;set;} = new Character[1];
        public Character[] Position2 {get;set;} = new Character[1];
        public Character[] Position3 {get;set;} = new Character[1];
        public Character[] Position4 {get;set;} = new Character[1];
        public Character[] Position5 {get;set;} = new Character[1];



//RELATIONSHIPS

        public int UserId {get;set;}


//NAVIGATION

        public User User {get;set;}


//DISPLAY



















    }
}