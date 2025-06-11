using Category.Infrastructure.interfaces.IServices;
using Category.Infrastructure.UnitOfWorkDb;
using Category.Infrastructure.ViewModels;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Category.BL.services
{
    public class CategoryService(IUnitOfWork unitOfWork ) : ICategoryService
    {
        public void createCategory(CategoryVM category)
        {
            var categoryVM = category.Adapt<Category.Infrastructure.Data.Models.Category>(); 
            unitOfWork.CategoryRepo.Create(categoryVM);
            unitOfWork.SaveChanges();
        }


        public void deleteCategory(CategoryVM category)
        {
            var categoryEntity = category.Adapt<Category.Infrastructure.Data.Models.Category>();
            unitOfWork.CategoryRepo.Delete(categoryEntity);
            unitOfWork.SaveChanges();
        }

        public async IAsyncEnumerable<CategoryVM> getAllCategories()
        {
            var categories = unitOfWork.CategoryRepo.GetAll(); // Assuming this returns IQueryable or IEnumerable
            foreach (var cat in categories)
            {
                yield return cat.Adapt<CategoryVM>();
                await Task.Yield(); // Allows yielding asynchronously
            }
        }

        public void updateCategory(CategoryVM category)
        {
            var categoryEntity = category.Adapt<Category.Infrastructure.Data.Models.Category>();
            unitOfWork.CategoryRepo.Update(categoryEntity);
            unitOfWork.SaveChanges();
        }
    }
}
