using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Hostility_Skirmish.Models.GameClasses
{
    public class Character
    {
//FIELDS
        [Key]
        public int CharacterId{get;set;}

        public bool TurnTaken {get;set;} = false;
        public bool IsAlive {get;set;} = true;


        //fields with _ are not changed during a match

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


        public string Avatar_Name {get;set;} = "";
        public string _Avatar_Image {get;set;} = "";
        public string Avatar_Image {get;set;} = "";


//RELATIONSHIPS


        public int PartyId {get;set;}


//NAVIGATIONS

        [JsonIgnore] 
        public Party Party {get;set;}




//ailments?

//Defender slot=[4]



//METHODS



        public int ChangeHealth(int amount){
            if (Health + amount < 0){
                Death();
            }
            Health = Health + amount;
            return amount;
        }

        public void Death(){
            IsAlive = false;
            TurnTaken = true;
            Avatar_Image = String.Concat(_Avatar_Image, "B");
            System.Console.WriteLine(Avatar_Image);
            Health = 0;
        }

        public int AbilityUse(Character target){
            int amount = Ability.AbilityUse(target, Ability_Slot);
            return amount;
        }

        public string AbilityDescription(){
            string desc = Ability.Description(Ability_Slot);
            return desc;
        }

        public int ItemUse(Character target){
            int amount = Item.ItemUse(target, Item_Slot);
            return amount;
        }

        public string ItemDescription(){
            string desc = Item.Description(Item_Slot);
            return desc;
        }

        public int Attack(Character target){
            int min = 1;
            int max = 8;
            Random rand = new Random();
            int amount = rand.Next(   min + ((AttackPower-1)*3),  max + ((AttackPower-1)*3)  );
            amount = -1 * (amount - target.GetDefense());
            target.ChangeHealth(amount);
            return amount;
        }

        public int GetDefense(){
            return DefensePower;
        }


    }
}