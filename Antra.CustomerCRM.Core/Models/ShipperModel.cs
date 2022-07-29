using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.CustomerCRM.Core.Models
{
	public class ShipperModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is Required")]
        [MaxLength(50, ErrorMessage = "Title must be less than 50 characters long")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Title is Required")]
        [MaxLength(10, ErrorMessage = "Title must be less than 10 characters long")]
        public string Phone { get; set; }
    }
}
