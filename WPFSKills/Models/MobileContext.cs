using System.Data.Entity;

namespace WPFSKills.Models
{
    class MobileContext:DbContext
    {

        public MobileContext() : base("ConnectionString")
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}
