using AutoPoco;
using AutoPoco.DataSources;
using AutoPoco.Engine;
using eButxaca.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eButxaca.TestingTools
{
    public static class POCOFactory
    {
        public static IList<Person> GeneratePeople(int numregisters)
        {
            IGenerationSessionFactory factory = AutoPocoContainer.Configure(x =>
            {
                x.Conventions(c => { c.UseDefaultConventions(); });
                x.AddFromAssemblyContainingType<Person>();
                x.Include<Person>()
                   .Setup(c => c.Id).Use<IntegerIdSource>()
                   .Setup(c => c.FirstName).Use<FirstNameSource>()
                   .Setup(c => c.DateEntityCreation).Use<DateOfBirthSource>()
                   .Setup(c => c.DateEntityModification).Use<DateOfBirthSource>();

            });

            IGenerationSession session = factory.CreateSession();

            IList<Person> students = session.List<Person>(numregisters).Get();
            return students;
        }

        public static Person GenerateSinglePerson()
        {
            IGenerationSessionFactory factory = AutoPocoContainer.Configure(x =>
            {
                x.Conventions(c => { c.UseDefaultConventions(); });
                x.AddFromAssemblyContainingType<Person>();
                x.Include<Person>()
                  .Setup(c => c.Id).Use<IntegerIdSource>()
                  .Setup(c => c.FirstName).Use<FirstNameSource>()
                  .Setup(c => c.DateEntityCreation).Use<DateOfBirthSource>()
                  .Setup(c => c.DateEntityModification).Use<DateOfBirthSource>();

            });

            IGenerationSession session = factory.CreateSession();

            return session.Single<Person>().Get();
        }
    }
}
