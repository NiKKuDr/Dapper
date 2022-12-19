using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DapperDemo.Models
{
    public class Company
    {
        // 6 properties
        // CompanyId is the Primary Key in EF (because it ends in Id)
        // That's why we do not have to specify that
        [Key] // manually adding company ID as a primary key (we can remove it at ll)
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        // [NotMapped]
        public List<Employee>  Employees{ get; set; }

    }
}
