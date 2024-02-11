using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace EfRelations.Services;

public static class DataService
{
    private static readonly AcademyContext _context = new();
    
    public static IEnumerable<T> GetAllData<T>(this IQueryable<T> queryable, Expression<Func<T, bool>>? expression=null, string? relatives=null) 
        where T : class, IEntity
    {
        var query = _context.Set<T>().AsQueryable(); // забираю таблицу из контекста

        if (relatives != null)
        {
            var tablesToInclude = relatives.Split(',', StringSplitOptions.TrimEntries);
        
            foreach (var item in tablesToInclude)
            {
                query = query.Include(item);
            }
        }
        
        if (expression != null)
        {
            query = query.Where(expression);
        }
        
        return query.AsEnumerable();
    }
}