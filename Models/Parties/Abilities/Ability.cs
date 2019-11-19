using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hostility_Skirmish.Models
{
    public abstract class Ability
    {
        [NotMapped]
        public string Name {get;set;}

        [NotMapped]
        public string Description {get;set;}

        //Methods
        public abstract void AbilityUse(Character target);

    }
}