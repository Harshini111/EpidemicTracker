using EpidemicTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpidemicTracker.Api.ViewModels
{
    public class PatientViewModel
    {
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public int OccupationId { get; set; }

        public string UniqueId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public AddressViewModel permanentAddress { get; set; }
        public AddressViewModel currentAddress { get; set; }
        public AddressViewModel occupationAddress { get; set; }

    }
}
