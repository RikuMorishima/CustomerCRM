using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.CustomerCRM.Core.Models
{
	public class ProductModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(30, ErrorMessage = "Name must be less than 30 characters long")]
        public string Name { get; set; }
        [Required(ErrorMessage = "SupplierId is Required")]
        public int SupplierId { get; set; }
        [Required(ErrorMessage = "CategoryId is Required")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "QuantityPerUnit is Required")]
        public int QuantityPerUnit { get; set; }
        [Required(ErrorMessage = "UnitPrice is Required")]
        public decimal UnitPrice { get; set; }
        [Required(ErrorMessage = "UnitsInStock is Required")]
        public int UnitsInStock { get; set; }
        [Required(ErrorMessage = "UnitsOnOrder is Required")]
        public int UnitsOnOrder { get; set; }
        [Required(ErrorMessage = "ReorderLevel is Required")]
        public int ReorderLevel { get; set; }
        [Required(ErrorMessage = "Discontined is Required")]
        public bool Discontined { get; set; }
        [Required(ErrorMessage = "VendorId is Required")]
        public int VendorId { get; set; }
    }
}
