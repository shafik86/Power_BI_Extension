using Microsoft.EntityFrameworkCore;
using Power_BI_Extension.Data;
using Power_BI_Extension.Models;

namespace Power_BI_Extension.Services
{
    public class DesignService : IDesignService
    {
        public DesignService(AppDbContext appDbContext)
        {
            _AppDbContext = appDbContext;
        }

        public AppDbContext _AppDbContext { get; }

        public async Task<PBIDesign> AddDesign(PBIDesign design)
        {
            if (design != null)
            {

                _AppDbContext.Designs.AddAsync(design);
                await _AppDbContext.SaveChangesAsync();
            }
            return design;
        }

        public async Task DeleteDesign(int designId)
        {
            var result = await _AppDbContext.Designs.FindAsync(designId);
            if (result != null)
            {
                _AppDbContext.Designs.Remove(result);
                await _AppDbContext.SaveChangesAsync();
            }
        }

        public async Task<List<PBIDesign>> getAllDesign()
        {
            var result = await _AppDbContext.Designs
                //.Include(c => c.CatId)
                .ToListAsync();
            if (result is null)
            {
                return null;
            }
            else
                return result;
        }



        public async Task<List<PBIDesign>> GetDesignByCategory(int designCategoryId)
        {
            var result = await _AppDbContext.Designs
                .Where(e => e.CatId == designCategoryId)
                //.Include(c => c.CatId)
                .ToListAsync();
            return result;
        }

        public async Task<PBIDesign> getDesignById(int designId)
        {
            var result = await _AppDbContext.Designs.FindAsync(designId);

            return result;
        }

        public async Task<PBIDesign> UpdateDesign(PBIDesign design)
        {
            var result = await _AppDbContext.Designs.FindAsync(design.Id);
            if (result != null)
            {
                result.Name = design.Name;
                result.Description = design.Description;
                result.CatId = design.CatId;
                result.Thumb = design.Thumb;
                result.PbiUrl = design.PbiUrl;

                await _AppDbContext.SaveChangesAsync();
            }
            return result;
        }
    }
}
