using Category.Infrastructure.Data.Models;
using Category.Infrastructure.interfaces.IRepositpories;
using Category.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Category.Infrastructure.UnitOfWorkDb
{
    public class UnitOfWork :IUnitOfWork
    {
        private readonly CategoryContext _Context;

        public ICategoryRepo CategoryRepo { get; }

        public UnitOfWork(CategoryContext context)
        {
            _Context = context;
            CategoryRepo = new CategoryRepo(_Context);
        }

        public void SaveChanges()
        {
            _Context.SaveChanges();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
