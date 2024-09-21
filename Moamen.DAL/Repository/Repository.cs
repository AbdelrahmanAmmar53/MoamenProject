using Microsoft.EntityFrameworkCore;
using Moamen2.DAL.Repository.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen2.DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;
        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public void Add(T item) => _dbSet.Add(item);

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            if(entity != null)
            {
                _dbSet.Remove(entity);
            }
        }
        public IEnumerable<T> GetAll() => _dbSet.ToList();
        public T GeyById(int id) => _dbSet.Find(id);
        public void Update(T item) => _dbSet.Update(item);
    }
}
