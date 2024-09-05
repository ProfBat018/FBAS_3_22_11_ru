using ProductData.Models;

namespace ProductRepository.Interfaces;


public interface IWarehouseRepository : IRepository<Warehouse>
{
    public void Update(Warehouse warehouse);
    public Task<Warehouse> FindByIdAsync(int id);
}