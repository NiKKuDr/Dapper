using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper.Models
{
    public class Company
    {
        [Key]  // optional refinement since CompanyId is the Primary key by default due to its Id ending
        public int CompanyId { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
    }
}
