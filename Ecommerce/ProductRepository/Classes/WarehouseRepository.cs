using ProductData.Contexts;
using ProductData.Models;
using ProductRepository.Classes;
using ProductRepository.Interfaces;

namespace ProductRepository.Classes;


public class WarehouseRepository : Repository<Warehouse>, IWarehouseRepository
{
    public WarehouseRepository(ProductContext context) : base(context)
    {
    }

    public void Update(Warehouse warehouse)
    {
        throw new NotImplementedException();
    }

    public Task<Warehouse> FindByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}