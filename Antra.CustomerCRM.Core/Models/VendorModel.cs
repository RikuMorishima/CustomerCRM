using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.CustomerCRM.Core.Models
{
	public class VendorModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(50, ErrorMessage = "Name must be less than 50 characters long")]
        public string Name { get; set; }
        [Required(ErrorMessage = "City is Required")]
        [MaxLength(50, ErrorMessage = "City must be less than 50 characters long")]
        public string City { get; set; }
        [Required(ErrorMessage = "Country is Required")]
        [MaxLength(50, ErrorMessage = "Country must be less than 50 characters long")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Mobile is Required")]
        [MaxLength(50, ErrorMessage = "Mobile must be less than 50 characters long")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "EmailId is Required")]
        [MaxLength(50, ErrorMessage = "EmailId must be less than 50 characters long")]
        public string EmailId { get; set; }
        [Required(ErrorMessage = "IsActive is Required")]
        public bool IsActive { get; set; }
    }
}
