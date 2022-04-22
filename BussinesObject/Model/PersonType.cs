using System;
using System.Collections.Generic;

namespace BussinesObject
{
   public class PersonType : BaseEntity
    {
        public PersonType()
        {
        }

        public PersonType(int id, string title)
        {
            ID = id;
            Title = title;
        }
        public String Title { get; set; }
     
        
    }
}
