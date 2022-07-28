using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Antra.CustomerCRM.Core.Entities
{
    public class Product
    {
        [Column(TypeName = "int")]
        public int Id { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string Name { get; set; }
        [Column(TypeName = "int")]
        public int SupplierId { get; set; }
        [Column(TypeName = "int")]
        public int CategoryId { get; set; }
        [Column(TypeName = "int")]
        public int QuantityPerUnit { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }
        [Column(TypeName = "int")]
        public int UnitsInStock { get; set; }
        [Column(TypeName = "int")]
        public int UnitsOnOrder { get; set; }
        [Column(TypeName = "int")]
        public int ReorderLevel { get; set; }
        [Column(TypeName = "bit")]
        public bool Discontined { get; set; }
        [Column(TypeName = "int")]
        public int VendorId { get; set; }
    }
}
