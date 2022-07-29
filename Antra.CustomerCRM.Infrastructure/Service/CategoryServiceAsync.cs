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
    public class CategoryServiceAsync : ICategoryServiceAsync
    {
        ICategoryRepositoryAsync repository;
        public CategoryServiceAsync(ICategoryRepositoryAsync repository)
        {
            this.repository = repository;
        }

        public async Task<int> DeleteModelAsync(int id)
        {
            return await repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<CategoryModel>> GetAllModelAsync()
        {
            var result = await repository.GetAllAsync();

            List<CategoryModel> list = new List<CategoryModel>();
            if (result != null)
            {
                foreach (var item in result)
                {
                    CategoryModel r = new CategoryModel();
                    r.Id = item.Id;
                    r.Name = item.Name;
                    r.Description = item.Description;

                    list.Add(r);
                }
            }
            return list;


        }

        public async Task<int> InsertModelAsync(CategoryModel model)
        {
            Category entity = new Category();
            entity.Name = model.Name;
            return await repository.InsertAsync(entity);
        }
    }
}
