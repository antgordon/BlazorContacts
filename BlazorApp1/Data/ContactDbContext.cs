using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;


namespace BlazorContacts.Data
{

    /// <summary>
    /// Used by the Entity Frame work to generate tables and access entities in the database
    /// </summary>
    public class ContactDbContext : DbContext { 

        public DbSet<Contact> Contacts { get; set; }

        public ContactDbContext(
         DbContextOptions<ContactDbContext> options)
         : base(options)
        {
        }

 
    }

 
}
