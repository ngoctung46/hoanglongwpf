using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; } = DateTime.Now;
        public DateTime BirthPlace { get; set; } = DateTime.Now;
        public DateTime IssueDate { get; set; } = DateTime.Now;
        public DateTime ExpiryDate { get; set; } = DateTime.Now;
        public string IssuePlace { get; set; }
        public Address Address { get; set; }
    }
}