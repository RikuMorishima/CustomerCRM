using Antra.CustomerCRM.Core.Contracts.Repository;
using Antra.CustomerCRM.Core.Entities;
using Antra.CustomerCRM.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.CustomerCRM.Infrastructure.Repository
{
    public class ProductRepositoryAsync : BaseRepositoryAsync<Product>, IProductRepositoryAsync
    {
        public ProductRepositoryAsync(CustomerCrmDbContext _context) : base(_context)
        {

        }
    }
}
