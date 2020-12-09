using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        ICollection<T> FindAll();
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();
    }
}
