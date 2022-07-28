using System;
using System.Collections.Generic;
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
        public string Name { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string Title { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string Address { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string City { get; set; }
        [Column(TypeName = "int")]
        public int RegionId { get; set; }
        [Column(TypeName = "int")]
        public int PostalCode { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Country { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string Phone { get; set; }

    }
}
