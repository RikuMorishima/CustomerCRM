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
        public async Task<int> InsertModelAsync(RegionModel regionModel)
        {
            Region regionEntity = new Region();
            regionEntity.Name = regionModel.Name;
            return await regionRepository.InsertAsync(regionEntity);
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

        public async Task<int> DeleteModelAsync(int id)
        {
            return await regionRepository.DeleteAsync(id);
        }

    }
}
