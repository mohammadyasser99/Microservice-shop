using Category.Infrastructure.Data.Models;
using Category.Infrastructure.interfaces.IRepositpories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Category.Infrastructure.Repositories
{
    public class GenericRepo<T>(CategoryContext _context) : IGenericRepo<T> where T : class
    {
        public void Create(T entity)
        {
    _context.Set<T>().Add(entity);  
        }

        public void Delete(T entity)
        {
    _context.Set<T>().Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public T? GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
