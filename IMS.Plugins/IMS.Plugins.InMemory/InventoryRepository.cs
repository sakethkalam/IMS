using System;
using IMS.CoreBusiness;
using IMS_UseCases.PluginsInterface;
namespace IMS.Plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly List<Inventory> _inventories;

        public InventoryRepository()
        {
            _inventories = new List<Inventory>()
           {
               new Inventory { InventoryId=1, InventoryName="cycle", price=15.5, Quantity=20},
               new Inventory { InventoryId=2, InventoryName="Car", price= 20.0, Quantity= 5},
               new Inventory { InventoryId=3, InventoryName="Bike", price= 100.0, Quantity=10}
           };
        }
        public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return await Task.FromResult(_inventories);

            return _inventories.Where(x => x.InventoryName.Contains(name,StringComparison.OrdinalIgnoreCase));
        }
    }
}

