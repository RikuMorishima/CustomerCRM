using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.CustomerCRM.Core.Entities
{
    public class Employee
    {
        [Column(TypeName = "int")]
        [Required]
        public int Id { get; set; }
        [Column(TypeName = "varchar(20)")]
        [Required]
        public string FirstName { get; set; }
        [Column(TypeName = "varchar(20)")]
        [Required]
        public string LastName { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Title { get; set; }
        [Column(TypeName = "varchar(5)")]
        [Required]
        public string TitleOfCourtesy { get; set; }
        [Column(TypeName = "datetime")]
        [Required]
        public DateTime BirthDate { get; set; }
        [Column(TypeName = "datetime")]
        [Required]
        public DateTime HireDate { get; set; }
        [Column(TypeName = "varchar(80)")]
        [Required]
        public string Address { get; set; }
        [Column(TypeName = "varchar(20)")]
        [Required]
        public string City { get; set; }
        [Column(TypeName = "int")]
        [Required]
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
        [Column(TypeName = "int")]
        public int ReportsTo { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        [Required]
        public string PhotoPath { get; set; }
    }
}
