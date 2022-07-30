using Antra.CustomerCRM.Core.Contracts.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Created this class to replicate the BaseRepositoryAsync class,
 * but cannot get a grasp on how to do it.
 */
namespace Antra.CustomerCRM.Infrastructure.Service
{
	public class BaseServiceAsync<T,K> : IServiceAsync<T> where T : class
	{
		public Task<int> DeleteModelAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<T>> GetAllModelAsync()
		{
			throw new NotImplementedException();
		}

        public Task<T> GetModelByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertModelAsync(T model)
		{
			throw new NotImplementedException();
		}

        public Task<int> UpdateModelAsync(T model)
        {
            throw new NotImplementedException();
        }
    }
}
