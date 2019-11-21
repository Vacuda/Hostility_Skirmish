using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Hostility_Skirmish.Models.GameClasses;

namespace Hostility_Skirmish.Models
{
    public class GameState //this is just a class!!! No direct entity interaction.
    {
        [Key]
        public int GameStateId{get;set;}
        public List<Character> Fighters {get;set;} //breathe
        //true for player one turn false for player two turn
        public bool current_turn{get;set;} = true;

        public bool PlayerOneLoss{get;set;} = false;
        public bool PlayerTwoLoss{get;set;} = false;
    }
}