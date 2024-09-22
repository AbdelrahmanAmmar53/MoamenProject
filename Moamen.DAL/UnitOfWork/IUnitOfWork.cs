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
        IUser Users { get; }
        ICategory Categories { get; }
        int save();
    }
}
