namespace Hostility_Skirmish.Models.Abilities
{
    public class ItemHeal : Item
    {

//Constructor
        public ItemHeal(){
            Name = "Heal";
            Description = "Target is healed 30HP";
            Image = "url";
        }


        public override void ItemUse(Character target){
            target.ChangeHealth(30);
        }

    }
}