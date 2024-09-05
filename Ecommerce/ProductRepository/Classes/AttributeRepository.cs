using ProductData.Contexts;
using ProductRepository.Classes;
using ProductRepository.Interfaces;

namespace ProductRepository.Classes;

public class AttributeRepository : Repository<Attribute>, IAttributeRepository
{
    public AttributeRepository(ProductContext context) : base(context)
    {
    }

    public void Update(Attribute attribute)
    {
        throw new NotImplementedException();
    }

    public Task<Attribute> FindByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}