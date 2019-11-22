
namespace Hostility_Skirmish.Models.GameClasses
{
    public class Item
    {

        public static int ItemUse(Character target, string item){

            if(item == "Heal"){
                int amount = target.ChangeHealth(40);
                return amount;
            }
            else{
                return 0;
            }

        }

        public static string Description(string item){

            if(item == "Heal"){
                string desc = "Raises HP by 40.";
                return desc;
            }
            
            return "";
        }
        








        

















    }
}