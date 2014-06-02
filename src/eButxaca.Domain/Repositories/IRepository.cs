using eButxaca.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace eButxaca.Domain.Repositories
{
    public abstract class Repository<T> //where T:class
    {
        public IUnitOfWork _UnitOfWork { private set; get; }

        public Repository()
        {
            throw new UnitOfWorkInicializationException();
        }

        public Repository(IUnitOfWork unitOfWorkProvided)
        {
            this._UnitOfWork = unitOfWorkProvided;
        }

        public abstract T GetById(object primaryKey);
        public abstract IEnumerable<T> GetByQuery();
        public abstract Int32 Insert(T itemToAdd);
        public abstract int Update(T itemToUpdate, Int32 PrimaryKey);
        public abstract int Update(T itemToUpdate);
        public abstract int Delete(Int32 primaryKeyValue);
        public abstract int Delete(T itemToDelete);

        //Page<T> PagedQuery<T>(long pageNumber, long itemsPerPage, string sql, params object[] args);
    }
}
