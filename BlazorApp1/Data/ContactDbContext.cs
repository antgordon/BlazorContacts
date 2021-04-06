using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;


namespace BlazorApp1.Data
{
    public class ContactDbContext : DbContext { 

        public DbSet<Contact> Contacts { get; set; }

        public ContactDbContext(
         DbContextOptions<ContactDbContext> options)
         : base(options)
        {
        }

 
    }

 
}
