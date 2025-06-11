
using Category.Infrastructure.interfaces.IServices;
using Category.Infrastructure.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Category.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController(ICategoryService _categoryService) : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateCategory([FromBody] CategoryVM category)
        {
            _categoryService.createCategory(category);
            return Ok(new { message = "Category created successfully" });
        }

        [HttpPut]
        public IActionResult UpdateCategory([FromBody] CategoryVM category)
        {
            _categoryService.updateCategory(category);
            return Ok(new { message = "Category updated successfully" });
        }

        [HttpDelete]
        public IActionResult DeleteCategory([FromBody] CategoryVM category)
        {
            _categoryService.deleteCategory(category);
            return Ok(new { message = "Category deleted successfully" });
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryVM>>> GetAllCategories()
        {
            var categories = new List<CategoryVM>();
            await foreach (var category in _categoryService.getAllCategories())
            {
                categories.Add(category);
            }
            return Ok(categories);
        }
    }
}
