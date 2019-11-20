using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hostility_Skirmish.Models
{
    public abstract class Item
    {
        [NotMapped]
        public string Name{get;set;}

        [NotMapped]
        public string Description {get;set;}

        [NotMapped]
        public string Image {get;set;}
            //point to a location?

        public abstract void ItemUse(Character target);

    }
}