using Power_BI_Extension.Models;

namespace Power_BI_Extension.Services
{
    public interface IDesignService
    {
        Task<List<PBIDesign>> getAllDesign();
        Task<PBIDesign> getDesignById(int designId);
    
        Task<PBIDesign> AddDesign(PBIDesign design);
        Task DeleteDesign(int designId);
        Task<PBIDesign> UpdateDesign(PBIDesign design);
        Task<List<PBIDesign>> GetDesignByCategory(int designCategoryId);
    }
}
