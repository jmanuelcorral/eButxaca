using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eButxaca.Domain.Entities
{
    public class Person:IEntity
    {
        public Int32 Id { get; set; }
        public DateTime DateEntityCreation { get; set; }
        public DateTime DateEntityModification { get; set; }
        public String HashkeyData { get; set; }
        public String FirstName { get; set; }
        public virtual ICollection<ContactDetail> ContactDetails { get; set; }
    }
}
