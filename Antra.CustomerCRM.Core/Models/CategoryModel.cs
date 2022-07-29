using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.CustomerCRM.Core.Models
{
	public class CategoryModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(20, ErrorMessage = "Name must be less than 20 characters long")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is Required")]
        [MaxLength(80, ErrorMessage = "Description must be less than 80 characters long")]
        public string Description { get; set; }
    }
}
