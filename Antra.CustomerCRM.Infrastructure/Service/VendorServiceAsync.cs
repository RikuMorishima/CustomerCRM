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
    public class VendorServiceAsync : IVendorServiceAsync
    {
        IVendorRepositoryAsync repository;
        public VendorServiceAsync(IVendorRepositoryAsync repository)
        {
            this.repository = repository;
        }

        public async Task<int> DeleteModelAsync(int id)
        {
            return await repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<VendorModel>> GetAllModelAsync()
        {
            var result = await repository.GetAllAsync();

            List<VendorModel> list = new List<VendorModel>();
            if (result != null)
            {
                foreach (var item in result)
                {
                    VendorModel r = new VendorModel();
                    r.Id = item.Id;
                    r.Name = item.Name;
                    r.City = item.City;
                    r.Country = item.Country;
                    r.Mobile = item.Mobile;
                    r.EmailId = item.EmailId;
                    r.IsActive = item.IsActive;

                    list.Add(r);
                }
            }
            return list;


        }

        public Task<VendorModel> GetModelByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> InsertModelAsync(VendorModel model)
        {
            Vendor r = new Vendor();
            r.Name = model.Name;
            r.City = model.City;
            r.Country = model.Country;
            r.Mobile = model.Mobile;
            r.EmailId = model.EmailId;
            r.IsActive = model.IsActive;
            return await repository.InsertAsync(r);
        }

        public Task<int> UpdateModelAsync(VendorModel model)
        {
            throw new NotImplementedException();
        }
    }
}
