using Moamen2.DAL.Repository.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen2.DAL.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        IUser User { get; }
        ICategory category { get; }
        int save();
    }
}
