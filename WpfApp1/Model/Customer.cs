using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model.Base;

namespace WpfApp1.Model
{
    public class Customer : ModelBase
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; } = DateTime.Now;
        public string BirthPlace { get; set; }
        public DateTime IssueDate { get; set; } = DateTime.Now;
        public DateTime ExpiryDate { get; set; } = DateTime.Now;
        public string IssuePlace { get; set; }
        public Address Address { get; set; }

        public Customer()
        {
        }
    }
}