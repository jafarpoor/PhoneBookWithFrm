using BussinesObject;
using System.Data.Entity;

namespace DataAccessLayer
{
   public class MyContext: DbContext
    {

        public DbSet<Person> Pepole { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Phone> Phones { get; set; }

        public DbSet<PersonType> PersonTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Person>().HasMany(x => x.Phones).WithRequired().WillCascadeOnDelete(true);
            modelBuilder.Entity<Person>().HasMany(x => x.Emails).WithRequired().WillCascadeOnDelete(true);
           

            base.OnModelCreating(modelBuilder);
        }

    }
}
