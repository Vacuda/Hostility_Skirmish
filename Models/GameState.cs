using Hostility_Skirmish.Models.GameClasses;

namespace Hostility_Skirmish.Models
{
    public class GameState //this is just a class!!! No direct entity interaction.
    {

        public Party PlayerOneParty {get;set;}
        public Party PlayerTwoParty {get;set;}
        //true for player one turn false for player two turn
        public bool current_turn{get;set;} = true;

        public bool PlayerOneLoss{get;set;} = false;
        public bool PlayerTwoLoss{get;set;} = false;

    }
}