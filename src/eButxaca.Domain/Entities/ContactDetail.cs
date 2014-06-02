using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eButxaca.Domain.Entities
{
    public class ContactDetail:IEntity
    {
        public Int32 Id { get; set; }
        public Int32 PersonId { get; set; }
        public DateTime DateEntityCreation { get; set; }
        public DateTime DateEntityModification { get; set; }
        public String HashkeyData { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
        public virtual Person ContactPerson { get; set; }
        public String AddressID { get; set; }
        
    }
}
