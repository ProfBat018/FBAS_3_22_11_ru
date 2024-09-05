namespace ProductRepository.Interfaces;

public interface IAttributeRepository : IRepository<Attribute>
{
    public void Update(Attribute attribute);
    public Task<Attribute> FindByIdAsync(int id);
}