using Microsoft.EntityFrameworkCore;
 
namespace Hostility_Skirmish.Models
{
    public class HomeContext : DbContext
    {
        public HomeContext(DbContextOptions options) : base(options) { }

        // public DbSet<####> #### {get;set;}
    }
}