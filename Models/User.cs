using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hostility_Skirmish.Models
{
    public class User
    {
        [Key]
        public int id {get;set;}
        [Required]
        [MinLength(2, ErrorMessage = "Must Be Longer then 2 Charecters")]
        [Display(Name="First Name")]
        public string FirstName {get;set;}
        [Required]
        [MinLength(2, ErrorMessage = "Must Be Longer then 2 Charecters")]
        [Display(Name="Last Name")]
        public string LastName {get;set;}
        [Required]
        [EmailAddress]
        public string Email {get;set;}

        [Required]
        [MinLength(8, ErrorMessage = "Must Be Longer then 8 Charecters")]
        [DataType(DataType.Password)]
        public string Password {get;set;}

        [NotMapped]
        [Compare("Password", ErrorMessage = "Passwords Must Match")]
        [DataType(DataType.Password)]
        public string Confirm {get;set;}
        // DateTime CreatedAt {get;set;} DateTime.Now();




        //Characters created List<Character>
        //Parties created List<Party>
        //Games Won List<string> - Include User.username
        //Games Lost List<string> - Include User.username


    }
}