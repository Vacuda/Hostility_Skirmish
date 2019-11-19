namespace Hostility_Skirmish.Models.Abilities
{
    public class AbilityHeal : Ability
    {
        public override void AbilityUse(Character target){
            target.ChangeHealth(30);
        }
    }
}