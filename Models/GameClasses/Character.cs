using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hostility_Skirmish.Models.GameClasses
{
    public class Character
    {
//FIELDS
        [Key]
        public int CharacterId{get;set;}


        public bool TurnTaken {get;set;}
        public bool IsAlive {get;set;} = true;


        public int _Health {get;set;}
        public int Health {get;set;}


        public int _AttackPower {get;set;}
        public int AttackPower {get;set;}


        public int _DefensePower {get;set;}
        public int DefensePower {get;set;}


//SLOTS

        public string _Item_Slot {get;set;} = "";
        public string Item_Slot {get;set;} = "";



        public string Ability_Slot {get;set;} = "";


        public string Avatar_Slot {get;set;} = "";


//RELATIONSHIPS


        public int PartyId {get;set;}


//NAVIGATIONS

        
        public Party Party {get;set;}




//ailments?

//Defender slot=[4]



//METHODS



        public void ChangeHealth(int amount){
            if (Health + amount < 0){
                Death();
            }
            Health = Health + amount;
        }

        public void Death(){
            IsAlive = false;
            Health = 0;
        }

        public void AbilityUse(Character target){
            Ability.AbilityUse(target, Ability_Slot);
        }

        public string AbilityDescription(){
            string desc = Ability.Description(Ability_Slot);
            return desc;
        }

        public void ItemUse(Character target){
            Item.ItemUse(target, Item_Slot);
        }

        public string ItemDescription(){
            string desc = Item.Description(Item_Slot);
            return desc;
        }


    }
}