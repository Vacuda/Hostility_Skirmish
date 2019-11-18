using System.ComponentModel.DataAnnotations;

namespace Hostility_Skirmish.Models
{
    public abstract class Item
    {
        
        public string Name{get;set;}

        public string Description {get;set;}

        public string Image {get;set;}
            //point to a location?

        public abstract void ItemUse(Character target);

    }
}