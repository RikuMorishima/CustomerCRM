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
    public class EmployeeServiceAsync : IEmployeeServiceAsync
    {
        IEmployeeRepositoryAsync repository;
        public EmployeeServiceAsync(IEmployeeRepositoryAsync repository)
        {
            this.repository = repository;
        }

        public async Task<int> DeleteModelAsync(int id)
        {
            return await repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<EmployeeModel>> GetAllModelAsync()
        {
            var result = await repository.GetAllAsync();

            List<EmployeeModel> list = new List<EmployeeModel>();
            if (result != null)
            {
                foreach (var item in result)
                {
                    EmployeeModel r = new EmployeeModel();
                    r.Id = item.Id;
                    r.FirstName = item.FirstName;
                    r.LastName = item.LastName;
                    r.Title = item.Title;
                    r.TitleOfCourtesy = item.TitleOfCourtesy;
                    r.BirthDate = item.BirthDate;
                    r.HireDate = item.HireDate;
                    r.Address = item.Address;
                    r.City = item.City;
                    r.RegionId = item.RegionId;
                    r.PostalCode = item.PostalCode;
                    r.Country = item.Country;
                    r.Phone = item.Phone;
                    r.ReportsTo = item.ReportsTo;
                    r.PhotoPath = item.PhotoPath;

                    list.Add(r);
                }
            }
            return list;


        }

        public Task<EmployeeModel> GetModelByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> InsertModelAsync(EmployeeModel model)
        {
            Employee r = new Employee();
            r.FirstName = model.FirstName;
            r.LastName = model.LastName;
            r.Title = model.Title;
            r.TitleOfCourtesy = model.TitleOfCourtesy;
            r.BirthDate = model.BirthDate;
            r.HireDate = model.HireDate;
            r.Address = model.Address;
            r.City = model.City;
            r.RegionId = model.RegionId;
            r.PostalCode = model.PostalCode;
            r.Country = model.Country;
            r.Phone = model.Phone;
            r.ReportsTo = model.ReportsTo;
            r.PhotoPath = model.PhotoPath;
            return await repository.InsertAsync(r);
        }

        public Task<int> UpdateModelAsync(EmployeeModel model)
        {
            throw new NotImplementedException();
        }
    }
}
