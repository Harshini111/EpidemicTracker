using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpidemicTracker.Api.ViewModels
{
    public class HospitalStaffViewModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int HospitalId { get; set; }
        public string Name { get; set; }
        public int StaffRoleId { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string AddressLine { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string Country { get; set; }
        public int Pincode { get; set; }
        public string UniqueId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
