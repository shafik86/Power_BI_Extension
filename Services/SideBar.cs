
using Microsoft.EntityFrameworkCore;
using Power_BI_Extension.Data;
using Power_BI_Extension.Models;

namespace Power_BI_Extension.Services
{
    public class SideBar : ISideBar
    {
        private readonly AppDbContext _appDbContext;

        public SideBar(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Category>> GetCategories()
        {
            
            try
            {
                var result = await _appDbContext.categories.ToListAsync();
                if (result is not null)
                {
                    return result;
                }
                return new List<Category>();
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
