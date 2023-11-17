using IMS.CoreBusiness;

namespace IMS_UseCases.Inventories
{
    public interface IViewInventoriesByNameUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string name = "");
    }
}