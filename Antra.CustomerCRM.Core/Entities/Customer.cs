using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.CustomerCRM.Core.Entities
{
    public class Customer
    {

        [Column(TypeName = "int")]
        public int Id { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string Title { get; set; }
        [Column(TypeName = "varchar(80)")]
        [Required]
        public string Address { get; set; }
        [Column(TypeName = "varchar(20)")]
        [Required]
        public string City { get; set; }
        [Column(TypeName = "int")]

        public int RegionId { get; set; }
        [Column(TypeName = "int")]
        [Required]
        public int PostalCode { get; set; }
        [Column(TypeName = "varchar(20)")]
        [Required]
        public string Country { get; set; }
        [Column(TypeName = "varchar(15)")]
        [Required]
        public string Phone { get; set; }


        // Navigational Properties
        public Region Region { get; set; }
    }
}
