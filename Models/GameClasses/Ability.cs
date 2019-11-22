
namespace Hostility_Skirmish.Models.GameClasses
{
    public class Ability
    {

        public static int AbilityUse(Character target, string ability){

            if(ability == "Heal"){
                int amount = 30;
                target.ChangeHealth(amount);
                return amount;
            }
            else{
                return 0;
            }
            if(ability == "Attack"){
                target.ChangeHealth(-40); //save db changes???
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