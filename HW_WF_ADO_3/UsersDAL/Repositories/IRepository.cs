using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersDAL.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> Get();
        T GetById(int id);
        void Add(T item);
        void Remove(T item);
        void Save();
    }
}
