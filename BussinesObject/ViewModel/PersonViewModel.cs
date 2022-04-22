using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesObject.ViewModel
{
  public  class PersonViewModel : BaseEntity
    {
        public String Name { get; set; }
        public String Family { get; set; }
        public String MainPhone { get; set; }
    }
}
