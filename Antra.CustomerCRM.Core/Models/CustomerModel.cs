using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.CustomerCRM.Core.Models
{
	public class CustomerModel
	{
        public int Id { get; set; }

		[Required(ErrorMessage = "Name is Required")]
		[MaxLength(30,ErrorMessage="Name must be less than 30 characters long")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Title is Required")]
        [MaxLength(30, ErrorMessage = "Title must be less than 30 characters long")]
        public string Title { get; set; }

		[Required(ErrorMessage = "Address is Required")]
		[MaxLength(80,ErrorMessage= "Address must be less than 80 characters long")]
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
    }
}
