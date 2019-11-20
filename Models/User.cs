using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hostility_Skirmish.Models.GameClasses;

namespace Hostility_Skirmish.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}
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

        //true if logged in false if logged out.
        public bool Logged {get;set;} = false; 


    //Navigations

        public List<Party> Parties {get;set;}



        //Games Won List<string> - Include User.username
        //Games Lost List<string> - Include User.username


    }
}