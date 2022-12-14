using Antra.CustomerCRM.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.CustomerCRM.Core.Models
{
    public class RegionModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Region Name is Required")]
        [MaxLength(50, ErrorMessage ="Region Name can be a maximum of 50 characters long")]
        public string Name { get; set; }
    }
}
