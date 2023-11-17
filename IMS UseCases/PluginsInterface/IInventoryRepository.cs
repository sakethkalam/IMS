using System;
using IMS.CoreBusiness;

namespace IMS_UseCases.PluginsInterface
{
	public interface IInventoryRepository
	{
         Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name);
    }
}

