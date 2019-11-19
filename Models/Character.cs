using System.ComponentModel.DataAnnotations;

namespace Hostility_Skirmish.Models
{
    public class Character
    {
//FIELDS
        [Key]
        public int CharacterId{get;set;}


        public int Health {get;set;}


        public bool IsAlive {get;set;} = true;
        

        public int AttackPower {get;set;}


        public int DefensePower {get;set;}


//SLOTS

        public Item[] Item_Slot {get;set;} = new Item[1];


        public Ability[] Ability_Slot {get;set;} = new Ability[1];


        public Avatar[] Avatar_Slot {get;set;} = new Avatar[1];


//RELATIONSHIPS


        public int UserId {get;set;}


//NAVIGATIONS

        public User User {get;set;}




//CONSTRUCTOR


        public Character(int health, int attack, int defense){
            Health = health;
            AttackPower = attack;
            DefensePower = defense;
            
        }




//Party slot = 

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







    }
}