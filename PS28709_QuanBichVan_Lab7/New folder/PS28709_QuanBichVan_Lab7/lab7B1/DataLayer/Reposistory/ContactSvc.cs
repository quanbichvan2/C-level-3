using DataLayer.Context;
using DataLayer.IRepository;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Service.Repository
{
    public class ContactSvc : IContactSvc
    {
        private readonly ContactDbContext db;

        public ContactSvc(ContactDbContext db)
        {
            this.db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public List<Contact>? GetList()
        {
            return db.Contacts.ToList();
        }

        public bool Add(Contact contact)
        {
            try
            {
                db.Contacts.Add(contact);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Contact contact)
        {
            var existingContact = db.Contacts.FirstOrDefault(c => c.Id == contact.Id);
            if (existingContact == null)
                return false;

            try
            {
                existingContact.Name = contact.Name;
                existingContact.Phone = contact.Phone;
                existingContact.Email = contact.Email;
                existingContact.Address = contact.Address;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(Contact contact)
        {
            var existingContact = db.Contacts.FirstOrDefault(c => c.Id == contact.Id);
            if (existingContact == null)
                return false;

            try
            {
                db.Contacts.Remove(existingContact);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Save()
        {
            try
            {
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
