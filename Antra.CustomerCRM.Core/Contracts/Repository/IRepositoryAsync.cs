using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.CustomerCRM.Core.Contracts.Repository
{
    public interface IRepositoryAsync<T> where T : class
    {
        Task<int> InsertAsync(T entity); // Async method, returns int
        Task<int> UpdateAsync(T entity);
        Task<int> DeleteAsync(int id);
        Task<T> GetByIdAsync(int id); // Async method, returns T

        Task<IEnumerable<T>> GetAllAsync(); // Async method, returns IEnumerable<T>
    }
}
