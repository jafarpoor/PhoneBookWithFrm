using System;
using System.Collections.Generic;

namespace BussinesObject
{
   public class PersonType
    {
        public int ID { get; set; }
        public String Title { get; set; }
        public List<Person> People { get; set; }

        public PersonType()
        {
            People = new List<Person>();
        }
    }
}
