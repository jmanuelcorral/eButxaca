using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eButxaca.Core.DAL.Mappings;
using eButxaca.Domain.Entities;

namespace eButxaca.Core.DAL.Contexts
{
    public class EntityDefaultContext:DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<ContactDetail> ContactDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonConfiguration());

            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
    }
}
