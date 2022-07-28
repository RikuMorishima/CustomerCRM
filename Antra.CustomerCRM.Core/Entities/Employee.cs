using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.CustomerCRM.Core.Entities
{
    public class Employee
    {
        [Column(TypeName = "int")]
        public int Id { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string FirstName { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string LastName { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Title { get; set; }
        [Column(TypeName = "varchar(5)")]
        public string TitleOfCourtesy { get; set; }
        [Column(TypeName = "datetime(7)")]
        public DateTime BirthDate { get; set; }
        [Column(TypeName = "datetime(7)")]
        public DateTime HireDate { get; set; }
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
        [Column(TypeName = "int")]
        public int ReportsTo { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        public string PhotoPath { get; set; }
    }
}
