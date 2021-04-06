using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data
{
    public class Contact
    {
        [Key]
        public Guid Id { set; get; }

        [MaxLength(250)]
        public string LastName { set; get; }

        [MaxLength(250)]
        public string FirstName { set; get; }

        [MaxLength(15)]
        public string PhoneNumber { set; get; }


        public DateTime BirthDate { set; get; }

    }
}
