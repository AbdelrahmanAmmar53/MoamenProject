using Microsoft.EntityFrameworkCore;
using Moamen2.DAL.Repository.IRepo;
using Moamen2.Modles.Modles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen2.DAL.Repository
{
    internal class CategoryRepository : Repository<Category>, ICategory
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
