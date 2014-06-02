using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using eButxaca.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace eButxaca.Core.DAL.Mappings
{
    public class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public  PersonConfiguration()
        {
            this.ToTable("People");
            //Primary Key Configuration
            this.HasKey(x => x.Id);
            this.Ignore(x => x.HashkeyData);
            this.HasRequired(x => x.ContactDetails).WithRequiredDependent().Map(m => m.MapKey("ContactDetailsId"));
            this.Property(x => x.FirstName).HasMaxLength(180);
        }

    }
}
