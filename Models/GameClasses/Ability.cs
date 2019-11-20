
namespace Hostility_Skirmish.Models.GameClasses
{
    public class Ability
    {

        public static void AbilityUse(Character target, string ability){

            if(ability == "Heal"){
                target.ChangeHealth(30);
            }

        }

        public static string Description(string ability){

            if(ability == "Heal"){
                string desc = "Raises HP by 30.";
                return desc;
            }
            
            return "";
        }
        








        

















    }
}