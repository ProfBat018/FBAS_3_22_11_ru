using ProductData.Models;

namespace ProductRepository.Interfaces;


public interface IOrderItemRepository : IRepository<OrderItem>
{
    public void Update(OrderItem orderItem);
    public Task<OrderItem> FindByIdAsync(int id);
}

