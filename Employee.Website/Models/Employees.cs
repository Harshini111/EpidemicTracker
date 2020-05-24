using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Employee.Website.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }
        public string About { get; set; }
        public override string ToString() => JsonSerializer.Serialize<Employees>(this);
    }
    
}
