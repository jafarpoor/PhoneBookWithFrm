using System.Data.Entity;

namespace BussinesObject
{
   public class MyContext: DbContext
    {

        public DbSet<Person> Pepole { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Phone> Phones { get; set; }

        public DbSet<PersonType> PersonTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
