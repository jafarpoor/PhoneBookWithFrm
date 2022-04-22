using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public abstract class Process
    {
        public abstract void Insert(object obj);
        public abstract void Delet();
        public abstract void Edit();

    }
}
