using System.ComponentModel.DataAnnotations;

namespace Hostility_Skirmish.Models
{
    public abstract class Ability
    {
        public string Name {get;set;}

        public string Description {get;set;}

        //Methods
        public abstract void AbilityUse(Character target);

    }
}