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
    public class ShipperServiceAsync : IShipperServiceAsync
    {
        IShipperRepositoryAsync repository;
        public ShipperServiceAsync(IShipperRepositoryAsync repository)
        {
            this.repository = repository;
        }

        public async Task<int> DeleteModelAsync(int id)
        {
            return await repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ShipperModel>> GetAllModelAsync()
        {
            var result = await repository.GetAllAsync();

            List<ShipperModel> list = new List<ShipperModel>();
            if (result != null)
            {
                foreach (var item in result)
                {
                    ShipperModel r = new ShipperModel();
                    r.Id = item.Id;
                    r.Name = item.Name;
                    r.Phone = item.Phone;

                    list.Add(r);
                }
            }
            return list;


        }

        public async Task<int> InsertModelAsync(ShipperModel model)
        {
            Shipper r = new Shipper();
            r.Name = model.Name;
            r.Phone = model.Phone;
            return await repository.InsertAsync(r);
        }
    }
}
