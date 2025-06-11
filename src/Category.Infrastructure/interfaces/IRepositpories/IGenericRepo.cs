using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Category.Infrastructure.interfaces.IRepositpories
{
     public interface IGenericRepo<T> where T : class
    {
        /*------------------------------------------------------------------------*/
        // Get All
        IEnumerable<T> GetAll();
        /*------------------------------------------------------------------------*/
        // Get One By Id
        T? GetById(int id);
        /*------------------------------------------------------------------------*/
        // Create
        void Create(T entity);
        /*------------------------------------------------------------------------*/
        // Update
        void Update(T entity);
        /*------------------------------------------------------------------------*/
        // Delete
        void Delete(T entity);
        /*------------------------------------------------------------------------*/

    }
}
