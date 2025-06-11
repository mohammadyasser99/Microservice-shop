using Category.Infrastructure.Data.Models;
using Category.Infrastructure.interfaces.IRepositpories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Category.Infrastructure.Repositories
{
    public class CategoryRepo :GenericRepo<Category.Infrastructure.Data.Models.Category>, ICategoryRepo
    {
        public CategoryRepo(CategoryContext category) : base(category)
        {
            
        }
    }
}
