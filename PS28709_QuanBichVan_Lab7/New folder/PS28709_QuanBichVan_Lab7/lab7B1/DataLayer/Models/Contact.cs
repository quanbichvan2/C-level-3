using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string Address { get; set; }

        public Contact(string name, string phone, string email, string address)
        {
            //if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(address))
            //{
            //    throw new ArgumentException("All fields (Name, Phone, Email, Address) are required and cannot be null or whitespace.");
            //}
            Name = name;
            Phone = phone;
            Email = email;
            Address = address;
        }
        public Contact(int id, string name, string phone, string email, string address)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
            Address = address;
        }
    }
}
