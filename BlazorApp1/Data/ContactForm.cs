using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data
{
    public class ContactForm
    {

        [Required(AllowEmptyStrings = false)]
        [StringLength(250)]
        public string LastName { set; get; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(250)]
        public string FirstName { set; get; }

        [StringLength(15, ErrorMessage = "Phone number too long (15 character limit)")]
        public string PhoneNumber { set; get; }


        public DateTime BirthDate { set; get; }

    }
}
