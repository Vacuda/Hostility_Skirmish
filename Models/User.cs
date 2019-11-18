using System.ComponentModel.DataAnnotations;

namespace Hostility_Skirmish.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}



        public string Username {get;set;}

























        //Characters created List<Character>
        //Parties created List<Party>
        //Games Won List<string> - Include User.username
        //Games Lost List<string> - Include User.username





    }
}