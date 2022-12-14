using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antra.CustomerCRM.Core.Contracts.Repository;
using Antra.CustomerCRM.Core.Contracts.Service;
using Antra.CustomerCRM.Core.Entities;
using Antra.CustomerCRM.Core.Models;

namespace Antra.CustomerCRM.Infrastructure.Service
{
    public class CustomerServiceAsync : ICustomerServiceAsync
    {
        ICustomerRepositoryAsync repository;
        public CustomerServiceAsync(ICustomerRepositoryAsync repository)
        {
            this.repository = repository;
        }

        public async Task<int> DeleteModelAsync(int id)
        {
            return await repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<CustomerModel>> GetAllModelAsync()
        {
            var result = await repository.GetAllAsync();

            List<CustomerModel> list = new List<CustomerModel>();
            if (result != null)
            {
                foreach (var item in result)
                {
                    CustomerModel r = new CustomerModel();
                    r.Id = item.Id;
                    r.Name = item.Name;
                    r.Title = item.Title;
                    r.Address = item.Address;
                    r.City = item.City;
                    r.RegionId=item.RegionId;
                    r.PostalCode = item.PostalCode;
                    r.Country = item.Country;
                    r.Phone = item.Phone;

                    list.Add(r);
                }
            }
            return list;
        }

        public async Task<CustomerModel?> GetModelByIdAsync(int id)
        {
            var item = await repository.GetByIdAsync(id);
            if (item != null)
            {
                CustomerModel r = new CustomerModel();
                r.Name = item.Name;
                r.Title = item.Title;
                r.Address = item.Address;
                r.City = item.City;
                r.RegionId = item.RegionId;
                r.PostalCode = item.PostalCode;
                r.Country = item.Country;
                r.Phone = item.Phone;
                return r;
            }
            return null;
        }

        public async Task<int> InsertModelAsync(CustomerModel model)
        {
            Customer entity = new Customer();
            entity.Name = model.Name;
            entity.Title = model.Title;
            entity.Address = model.Address;
            entity.City = model.City;
            entity.RegionId = model.RegionId;
            entity.PostalCode = model.PostalCode;
            entity.Country = model.Country;
            entity.Phone = model.Phone;
            return await repository.InsertAsync(entity);
        }

        public async Task<int> UpdateModelAsync(CustomerModel model)
        {
            Customer entity = new Customer();
            entity.Name = model.Name;
            entity.Title = model.Title;
            entity.Address = model.Address;
            entity.City = model.City;
            entity.RegionId = model.RegionId;
            entity.PostalCode = model.PostalCode;
            entity.Country = model.Country;
            entity.Phone = model.Phone;
            return await repository.UpdateAsync(entity);
        }
    }
}
