using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace eButxaca.Domain
{
    interface IEntity
    {
        Int32 Id { get; set; }
        DateTime DateEntityCreation { get; set; }
        DateTime DateEntityModification { get; set; }
        String HashkeyData { get; set; }
    }
}
