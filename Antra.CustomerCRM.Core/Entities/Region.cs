using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Antra.CustomerCRM.Core.Entities
{
    public class Region
    {

        public int Id { get; set; }
        [Column(TypeName ="varchar(50)")]
        [Required]
        public string Name { get; set; }


        //Navigational Properties
        public ICollection<Customer> CustomersRef { get; set; }
        public ICollection<Employee> EmployeesRef { get; set; }
    }
}
