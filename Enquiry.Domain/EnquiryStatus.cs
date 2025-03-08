using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enquiry.Domain
{
    public class EnquiryStatus
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int statusId { get; set; }
        [Required]
        public string statusName { get; set; } = string.Empty;
    }
}
