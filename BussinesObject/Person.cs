using System;
using System.Collections.Generic;

namespace BussinesObject
{
   public class Person
    {
        public int ID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Adress { get; set; }
        public PersonType PersonType { get; set; }
        public List<Phone> Phones { get; set; }
        public List<Email> Emails { get; set; }

        public Person()
        {
            Phones = new List<Phone>();
            Emails = new List<Email>();
            PersonType = new PersonType();
        }

    }
}
