using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.CustomerCRM.Core.Models
{
	public class EmployeeModel
	{

        public int Id { get; set; }

        [Required(ErrorMessage = "FirstName is Required")]
        [MaxLength(20, ErrorMessage = "FirstName must be less than 20 characters long")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is Required")]
        [MaxLength(20, ErrorMessage = "LastName must be less than 20 characters long")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Title is Required")]
        [MaxLength(50, ErrorMessage = "Title must be less than 50 characters long")]
        public string Title { get; set; }

        [Required(ErrorMessage = "TitleOfCourtesy is Required")]
        [MaxLength(5, ErrorMessage = "TitleOfCourtesy must be less than 5 characters long")]
        public string TitleOfCourtesy { get; set; }
        [Required(ErrorMessage = "BirthDate is Required")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "HireDate is Required")]
        public DateTime HireDate { get; set; }

        [Required(ErrorMessage = "Address is Required")]
        [MaxLength(80, ErrorMessage = "Address must be less than 80 characters long")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is Required")]
        [MaxLength(20, ErrorMessage = "City must be less than 20 characters long")]
        public string City { get; set; }
        [Required(ErrorMessage = "RegionId is Required")]
        public int RegionId { get; set; }
        [Required(ErrorMessage = "PostalCode is Required")]
        public int PostalCode { get; set; }

        [Required(ErrorMessage = "Country is Required")]
        [MaxLength(20, ErrorMessage = "Country must be less than 20 characters long")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Phone is Required")]
        [MaxLength(15, ErrorMessage = "Phone must be less than 15 characters long")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "ReportsTo is Required")]
        public int ReportsTo { get; set; }

        [Required(ErrorMessage = "PhotoPath is Required")]
        public string PhotoPath { get; set; }
    }
}
