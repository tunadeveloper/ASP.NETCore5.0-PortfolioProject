using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortfolioProject.APILayer.DataAccess.ApiContext;
using PortfolioProject.APILayer.DataAccess.Entity;
using System.Linq;

namespace PortfolioProject.APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly Context _context;

        public CategoryController(Context context)
        {
            _context = context;
        }


        [HttpGet("CategoryList")]
        public IActionResult CategoryList()
        {
            return Ok(_context.Categories.ToList());
        }

        [HttpGet("CategoryById/{id}")]
        public IActionResult CategoryById(int id)
        {
            return Ok(_context.Categories.Find(id));
        }

        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
           var values = _context.Categories.Add(category);
            _context.SaveChanges();
            return Ok("Kategori Eklendi: " + values);
        }

        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            var value = _context.Categories.Find(id);
            _context.Categories.Remove(value);
            _context.SaveChanges();
            return Ok("Kategori Silindi: " + value.CategoryName);
        }

        [HttpPut]
        public IActionResult UpdateCategory(Category category)
        {
            var value = _context.Categories.Find(category.ID);
            value.CategoryName = category.CategoryName;
            _context.Categories.Update(value);
            _context.SaveChanges();
            return Ok("Kategori Güncellendi: " + value.CategoryName);
        }
    }
}
