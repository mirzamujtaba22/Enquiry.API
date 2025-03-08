using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enquiry.Domain
{
    public class EnquiryModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int enquiryId { get; set;}
        [Required]
        public int enquiryTypeId { get; set; }

        public int enquiryStatusId { get; set; }

        public string CustomerName { get; set; } = string.Empty;
        public string mobileNo { get; set; } = string.Empty;

        public string email { get; set; } = string.Empty;
        public string message { get; set; } = string.Empty;

        public DateTime createdDate { get; set; }

        public string resolution { get; set; } = string.Empty;







    }
}
