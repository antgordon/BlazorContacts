using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorContacts.Data
{

    /// <summary>
    /// The data model for the contacts in the database
    /// </summary>
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
