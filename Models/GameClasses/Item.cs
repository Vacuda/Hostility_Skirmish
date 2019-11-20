
namespace Hostility_Skirmish.Models.GameClasses
{
    public class Item
    {

        public static void ItemUse(Character target, string item){

            if(item == "Heal"){
                target.ChangeHealth(40);
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