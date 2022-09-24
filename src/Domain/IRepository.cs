using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T?> ReadAsync(Guid id);

        Task<IEnumerable<T>> ReadListAsync();

        Task<T> CreateAsync(T entity);

        Task UpdateAsync(T entity);
    }
}