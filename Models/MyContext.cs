
using Hostility_Skirmish.Models.GameClasses;
using Hostility_Skirmish.Models;
using Microsoft.EntityFrameworkCore;
 
namespace Hostility_Skirmish.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }

         public DbSet<User> Users {get;set;}
         public DbSet<Party> Parties {get;set;}
         public DbSet<Character> Characters {get;set;}
         public DbSet<GameState> GameStates {get;set;}

    }
}
