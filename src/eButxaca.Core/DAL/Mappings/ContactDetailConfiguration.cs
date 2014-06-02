using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eButxaca.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace eButxaca.Core.DAL.Mappings
{
    public class ContactDetailConfiguration : EntityTypeConfiguration<ContactDetail>
    {
        public ContactDetailConfiguration()
        {
            this.ToTable("ContactDetails");
            //Primary Key Configuration & IEntity Mapping Configuration
            this.HasKey(x => x.Id);
            this.Ignore(x => x.HashkeyData);
        }
    }
}
