using Microsoft.EntityFrameworkCore;
using Moamen2.DAL.Repository;
using Moamen2.DAL.Repository.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen2.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        public IUser Users { get; }
        public ICategory Category { get; }

        public IUser User => throw new NotImplementedException();

        public ICategory category => throw new NotImplementedException();

        public UnitOfWork(DbContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
            Category = new CategoryRepository(_context);
        }
        public void Dispose() => _context.Dispose();
        public int save() => _context .SaveChanges();
    }
}
