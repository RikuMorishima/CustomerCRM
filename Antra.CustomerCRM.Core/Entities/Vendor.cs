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
        public string Name { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string City { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Country { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Mobile { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string EmailId { get; set; }
        [Column(TypeName = "bit")]
        public bool IsActive { get; set; }
    }
}
