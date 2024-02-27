using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6B2.Models
{
    public class BookStore
    {
        public string BookId { get; set; } = string.Empty;
        public string BookName { get; set; } = string.Empty;
        public decimal BookPrice { get; set; }
        public int Amount { get; set; }
    }
}
