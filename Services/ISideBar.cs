using Power_BI_Extension.Models;

namespace Power_BI_Extension.Services
{
    public interface ISideBar
    {
        Task<List<Category>> GetCategories();
    }
}
