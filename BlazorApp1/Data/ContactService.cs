using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class ContactService
    {
      private IList<Contact> contants = new List<Contact>();
       

        public ContactService() {

        
            contants.Add(new Contact
            {
                Id = new Guid("F9168C5E-CEB2-4faa-B6BF-329BF39FA1E4"),
                FirstName = "Tony",
                LastName = "Gordo",
                BirthDate = new DateTime(1990, 1, 1),
                PhoneNumber = "75555555"
            }) ;

            contants.Add(new Contact
            {
                Id = new Guid("936DA01F-9ABD-4d9d-80C7-02AF85C822A8"),
                FirstName = "Mundu",
                LastName = "Yaiko",
                BirthDate = new DateTime(1993, 7, 6),
                PhoneNumber = "858383023"
            });
        }

        public ICollection<Contact> GetContacts() {
            // return context.Contacts.ToList();

            return contants;
        }

        public Contact? GetContact(Guid id) {

            foreach (var con in contants) { 
                if (con.Id.Equals(id)) {
                    return con;
                }
            }


            return null;
        }

        public void AddContact(Contact contact)
        {

            //context.Contacts.Add(contact);
            //context.SaveChanges();

            contants.Add(contact);
        }

        public void RemoveContact(Contact contact)
        {

            contants.Remove(contact);
            //context.Contacts.Remove(contact);
            //context.SaveChanges();
        }
    }
}
