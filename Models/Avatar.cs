using System.ComponentModel.DataAnnotations;

namespace Hostility_Skirmish.Models
{
    public class Avatar
    {
        [Key]
        public int AvatarId {get;set;}

        [Required]
        public string Name {get;set;}

        //Point to Image
        //Point to Animation

        //this will house the Name of the character chosen and the animations and images associated with it
        //I think all of this info will be static, not customizable.


    }
}