using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eButxaca.Domain.Repositories
{
    public class GenericRepository<T>: Repository<T> where T:class
    {

        public override T GetById(object primaryKey)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<T> GetByQuery()
        {
            throw new NotImplementedException();
        }

        public override int Insert(T itemToAdd)
        {
            throw new NotImplementedException();
        }

        public override int Update(T itemToUpdate, int PrimaryKey)
        {
            throw new NotImplementedException();
        }

        public override int Update(T itemToUpdate)
        {
            throw new NotImplementedException();
        }

        public override int Delete(int primaryKeyValue)
        {
            throw new NotImplementedException();
        }

        public override int Delete(T itemToDelete)
        {
            throw new NotImplementedException();
        }
    }
}
