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
        public async Task<int> InsertRegion(RegionModel regionModel)
        {
            Region regionEntity = new Region();
            regionEntity.Name = regionModel.Name;
            return await regionRepository.InsertAsync(regionEntity);
        }
        public async Task<IEnumerable<RegionModel>> GetAllRegions()
        {
            var result = await regionRepository.GetAllAsync();
            IEnumerable<Region> regions = new List<Region>();
            if (result != null)
                regions = result;
            return regions;
        }
            


    }
}
