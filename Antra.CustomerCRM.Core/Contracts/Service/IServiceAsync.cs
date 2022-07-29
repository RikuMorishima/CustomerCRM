using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.CustomerCRM.Core.Contracts.Service
{
	public interface IServiceAsync<T> where T : class
	{
		Task<int> InsertModelAsync(T model);
		Task<IEnumerable<T>> GetAllModelAsync();
		Task<int> DeleteModelAsync(int id);
	}
}
