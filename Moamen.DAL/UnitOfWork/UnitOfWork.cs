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
        public ICategory Categories { get; }
        public UnitOfWork(DbContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
            Categories = new CategoryRepository(_context);
        }
        public void Dispose() => _context.Dispose();
        public int save() => _context .SaveChanges();
    }
}
