using CemTest.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CemTest.Data.Repository
{
    public abstract class GenericRepository<TContext, Tentity> : IRepository<Tentity>
        where Tentity : BaseEntity, new() 
        where TContext : DefaultContext, new()
    {
        public TContext _defaultContext = new TContext();
        public TContext defaultContext
        {
            get
            {
                return _defaultContext;
            }
            set
            {
                _defaultContext = value;
            }
        }

        public virtual bool Delete(Tentity obj)
        {
            throw new NotImplementedException();
        }

        public virtual List<Tentity> GetAll()
        {
            return defaultContext.Set<Tentity>().ToList();
        }

        public virtual Tentity GetbyId(int id)
        {
            throw new NotImplementedException();
        }

        public virtual bool Insert(Tentity obj)
        {
            defaultContext.Set<Tentity>().Add(obj);
            defaultContext.SaveChanges();
            return true;
        }

        public virtual bool Update(Tentity obj)
        {
            throw new NotImplementedException();
        }
    }
}
