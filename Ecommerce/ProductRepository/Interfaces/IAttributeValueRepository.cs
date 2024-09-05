using ProductData.Models;

namespace ProductRepository.Interfaces;


public interface IAttributeValueRepository : IRepository<AttributeValue>
{
    public void Update(AttributeValue attributeValue);
    public Task<AttributeValue> FindByIdAsync(int id);
}




