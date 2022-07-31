using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Antra.CustomerCRM.Core.Entities
{
    public class Vendor
    {
        [Column(TypeName = "int")]
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string City { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Country { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Mobile { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string EmailId { get; set; }
        [Column(TypeName = "bit")]
        [Required]
        public bool IsActive { get; set; }

        public ICollection<Product> ProductsRef { get; set; }
    }
}
