using System.ComponentModel.DataAnnotations;

namespace Hostility_Skirmish.Models
{
    public abstract class Item
    {
        
        


        [Key]
        public int ItemId {get;set;}


        public string Name{get;set;}


        public string Description {get;set;}


        public string Image {get;set;}
            //point to a location?




        public void ItemUse(Character target){
            //item use
        }


        

















    }
}