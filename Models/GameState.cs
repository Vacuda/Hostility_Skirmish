using System.Collections.Generic;
using Hostility_Skirmish.Models.GameClasses;

namespace Hostility_Skirmish.Models
{
    public class GameState //this is just a class!!! No direct entity interaction.
    {

        public int GameStateId {get;set;}

        public string CurrentTeam{get;set;}


//Navigations
        public List<Party> Parties {get;set;}

    }
}