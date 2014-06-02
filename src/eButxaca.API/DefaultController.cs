using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using eButxaca.Domain.Entities;
using eButxaca.TestingTools;

namespace eButxaca.API
{
    public class DefaultController: ApiController
    {


        // GET api/values 
        public IEnumerable<Person> Get()
        {
            return POCOFactory.GeneratePeople(100);
        }

        // GET api/values/5 
        public Person Get(int id)
        {
            return POCOFactory.GenerateSinglePerson();
        }

        // POST api/values 
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5 
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/values/5 
        public void Delete(int id)
        {

        } 
    }
}
