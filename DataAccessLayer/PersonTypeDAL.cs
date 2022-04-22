using BussinesObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
  public  class PersonTypeDAL
    {
        MyContext ctx = new MyContext();
        public void Inset(PersonType personType)
        {
            PersonType PT = new PersonType() {
                Title = personType.Title,
                ID = personType.ID,

            };

            ctx.PersonTypes.Add(PT);
            ctx.SaveChanges();

        }

        public void Delet(int id)
        {
            var personType = ctx.PersonTypes.Find(id);
            if (personType != null && personType.ID > 0)
            {
                ctx.PersonTypes.Remove(personType);
                ctx.SaveChanges();
            }
            PersonType PT = new PersonType()
            {
                Title = personType.Title,
                ID = personType.ID,

            };

        }

        public List<PersonType> View()
        {
            List<PersonType> li = new List<PersonType>();

            foreach (PersonType item in ctx.PersonTypes)
            {
                li.Add(new PersonType(item.ID, item.Title));
            }

            return li;
        }

        
    }
}
