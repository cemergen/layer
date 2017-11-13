using CemTest.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CemTest.Data.Repository
{
    public interface IRepository<Tentity> 
    {
        List<Tentity> GetAll();
        Tentity GetbyId(int id);
        bool Delete(Tentity obj);
        bool Insert(Tentity obj);
        bool Update(Tentity obj);
    }
}
