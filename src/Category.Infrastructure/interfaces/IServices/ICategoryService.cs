using Category.Infrastructure.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Category.Infrastructure.interfaces.IServices
{
    public interface ICategoryService
    {
        void createCategory(CategoryVM category);
        
        void updateCategory(CategoryVM category);

        IAsyncEnumerable<CategoryVM> getAllCategories();

        void deleteCategory(CategoryVM category);
    }
}
