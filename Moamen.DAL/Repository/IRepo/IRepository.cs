using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen2.DAL.Repository.IRepo
{
   public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GeyById(int id);
        void Add(T item);
        void Update(T item);
        void Delete(int id);

    }
}
