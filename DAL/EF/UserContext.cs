using DAL.Entities;
using System.Data.Entity;

namespace DAL.EF
{
    public class UserContext : DbContext

    {

        public DbSet<User> User { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Street> Streets { get; set; }


        public UserContext() : base("DefaultConnection1") { }

        
    }
}
