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
    public class ProductServiceAsync : IProductServiceAsync
    {
        IProductRepositoryAsync repository;
        public ProductServiceAsync(IProductRepositoryAsync repository)
        {
            this.repository = repository;
        }

        public async Task<int> DeleteModelAsync(int id)
        {
            return await repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ProductModel>> GetAllModelAsync()
        {
            var result = await repository.GetAllAsync();

            List<ProductModel> list = new List<ProductModel>();
            if (result != null)
            {
                foreach (var item in result)
                {
                    ProductModel r = new ProductModel();
                    r.Id = item.Id;
                    r.Name = item.Name;
                    r.SupplierId = item.SupplierId;
                    r.CategoryId = item.CategoryId;
                    r.QuantityPerUnit = item.QuantityPerUnit;
                    r.UnitPrice = item.UnitPrice;
                    r.UnitsInStock = item.UnitsInStock;
                    r.UnitsOnOrder = item.UnitsOnOrder;
                    r.ReorderLevel = item.ReorderLevel;
                    r.Discontined = item.Discontined;
                    r.VendorId = item.VendorId;

                    list.Add(r);
                }
            }
            return list;


        }

        public Task<ProductModel> GetModelByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> InsertModelAsync(ProductModel model)
        {
            Product r = new Product();
            r.Name = model.Name;
            r.SupplierId = model.SupplierId;
            r.CategoryId = model.CategoryId;
            r.QuantityPerUnit = model.QuantityPerUnit;
            r.UnitPrice = model.UnitPrice;
            r.UnitsInStock = model.UnitsInStock;
            r.UnitsOnOrder = model.UnitsOnOrder;
            r.ReorderLevel = model.ReorderLevel;
            r.Discontined = model.Discontined;
            r.VendorId = model.VendorId;
            return await repository.InsertAsync(r);
        }

        public Task<int> UpdateModelAsync(ProductModel model)
        {
            throw new NotImplementedException();
        }
    }
}
