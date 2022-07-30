using Antra.CustomerCRM.Core.Contracts.Repository;
using Antra.CustomerCRM.Core.Contracts.Service;
using Antra.CustomerCRM.Core.Entities;
using Antra.CustomerCRM.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.CustomerCRM.Infrastructure.Service
{
    public class RegionServiceAsync : IRegionServiceAsync
    {
        IRegionRepositoryAsync regionRepository;
        public RegionServiceAsync(IRegionRepositoryAsync _regionRepository)
        {
            regionRepository = _regionRepository;
        }
        public Task<int> InsertModelAsync(RegionModel regionModel)
        {
            Region regionEntity = new Region();
            regionEntity.Name = regionModel.Name;
            return regionRepository.InsertAsync(regionEntity);
        }
        public async Task<IEnumerable<RegionModel>> GetAllModelAsync()
        {
            var result = await regionRepository.GetAllAsync();

            List<RegionModel> regions = new List<RegionModel>();
            if (result != null)
            {
                foreach (var item in result)
                {
                    RegionModel r = new RegionModel();
                    r.Id = item.Id;
                    r.Name = item.Name;
                    regions.Add(r);
                }
            }
            return regions;
        }

        public Task<int> DeleteModelAsync(int id)
        {
            return regionRepository.DeleteAsync(id);
        }

        public Task<int> UpdateModelAsync(RegionModel model)
        {
            Region regionEntity = new Region()
            {
                Name = model.Name,
                Id = model.Id
            };
            return regionRepository.UpdateAsync(regionEntity);
        }

        public async Task<RegionModel> GetModelByIdAsync(int id)
        {
            Region entity = await regionRepository.GetByIdAsync(id);
            if (entity != null)
            {
                RegionModel model = new RegionModel()
                {
                    Name = entity.Name,
                    Id = entity.Id
                };
                return model;
            }
            return null;
        }
    }
}
