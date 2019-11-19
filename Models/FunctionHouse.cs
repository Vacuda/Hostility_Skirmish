

using Hostility_Skirmish.Models.Abilities;

namespace Hostility_Skirmish.Models
{
    public class FH
    {
        

        public static Avatar GetAvatar(int avatar_id){
            Avatar avatar = new Avatar();
            avatar.Name = "Avatar";
            return avatar;
        }

        public static Ability GetAbility(string name){
            Ability ability = new AbilityHeal();
            ability.Name = "Ability";
            return ability;
        }

        public static Item GetItem(string name){
            Item item = new ItemHeal();
            item.Name = "Item";
            return item;
        }












    }
}