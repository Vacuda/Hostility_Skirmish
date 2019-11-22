using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Hostility_Skirmish.Models
{
    public class Log
    {
        [Key]
        public int LogId {get;set;}

        public string Content {get;set;}

    //Relationship

        public int GameStateId {get;set;}

    //Navigation

        public GameState GameState {get;set;}





    }
}