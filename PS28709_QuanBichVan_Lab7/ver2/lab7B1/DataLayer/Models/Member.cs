using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    [Table("Member")]
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(11)]
        public string? Phone { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Email { get; set; }

        public Member(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }
        public Member(int id, string name, string phone, string email)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
        }
    }
}
