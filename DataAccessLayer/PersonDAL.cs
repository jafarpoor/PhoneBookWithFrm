using BussinesObject;
using BussinesObject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer
{
    public class PersonDAL  
    {

       MyContext ctx = new MyContext();
        public void Delet(int id)
        {
            var person = ctx.Pepole.Find(id);
            if (person != null && person.ID>0)
            {
                ctx.Pepole.Remove(person);
                ctx.SaveChanges();
            }
          
        }

        public void Insert(Person person)
        { 
            ctx.Pepole.Add(person);
            ctx.SaveChanges();
        }

        public List<PersonViewModel> ViewPerson()
        {
            var q = from a in ctx.Pepole
                    select new PersonViewModel
                    {
                        ID = a.ID,
                        Name = a.FirstName,
                        Family = a.LastName,
                        MainPhone = a.Phones.Count>0 ? a.Phones.FirstOrDefault().Number : " No Phones !!",

                    };
            return q.ToList();


        }

    }
 }  

