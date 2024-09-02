using Microsoft.EntityFrameworkCore;
using Power_BI_Extension.Data;
using Power_BI_Extension.Models;

namespace Power_BI_Extension.Services
{
    public class CategoryService : ICategoryService
    {
        public CategoryService(AppDbContext appDbContext)
        {
            _AppDbContext = appDbContext;
        }

        public AppDbContext _AppDbContext { get; }

        public async Task DeleteCategory(int id)
        {
            var result = await _AppDbContext.categories.FindAsync(id);
            if (result == null)
            {
                return;
            }
            _AppDbContext.categories.Remove(result);
            await _AppDbContext.SaveChangesAsync();
            return;
        }

        public async Task<List<Category>> GetAllCategories()
        {
            var result = await _AppDbContext.categories.ToListAsync();
            return result;
        }

        public async Task<Category> GetCategoryById(int id)
        {
            var result = await _AppDbContext.categories.FindAsync(id);
            
                return result;
            
        }

        public async Task<Category> GetCategoryByName(string categoryName)
        {
            var result = await _AppDbContext.categories.FindAsync(categoryName);
            return result;
        }

        public async Task<Category> UpdateCategory(Category category)
        {
            var result = await _AppDbContext.categories.FindAsync(category.Id);
            if (result != null)
            {
                result.Name = category.Name;
                
                _AppDbContext.categories.Update(result);
                await _AppDbContext.SaveChangesAsync();
            }
            return result;
        }
    }
}
