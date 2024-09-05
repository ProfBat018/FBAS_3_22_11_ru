using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ProductData.Models;

namespace ProductRepository.Interfaces;

    public interface IRepository<T>
    {
        Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter, string includeProperties = null, bool tracked = true);
        Task<PaginatedList<T>> GetAllAsync(int pageNumber, int pageSize, Expression<Func<T, bool>> filter = null, string includeProperties = null);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
