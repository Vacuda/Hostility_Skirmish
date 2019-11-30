using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Hostility_Skirmish.Models.GameClasses;

namespace Hostility_Skirmish.Models
{
    public class GameState
    {
        [Key]
        public int GameStateId {get;set;}

        public string CurrentTeam{get;set;}

//Navigations
        public List<Party> Parties {get;set;}


        public List<Log> Logs {get;set;}

    }
}