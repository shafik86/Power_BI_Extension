using Power_BI_Extension.Models;

namespace Power_BI_Extension.Services
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }
        Task<List<Category>> GetAllCategories();
        
        Task<Category> GetCategoryById(int id);
        Task<Category> GetCategoryByName(string categoryName);
        Task<Category> UpdateCategory(Category category);
        Task DeleteCategory(int id);
        

    }
}
