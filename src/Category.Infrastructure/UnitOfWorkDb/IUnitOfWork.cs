using Category.Infrastructure.interfaces.IRepositpories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Category.Infrastructure.UnitOfWorkDb
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepo CategoryRepo { get; }
        void SaveChanges();
    }
}
