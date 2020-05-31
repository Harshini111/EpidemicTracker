using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpidemicTracker.Api.ViewModels
{
    public class AddressViewModel
    {
        public int PatientId { get; set; }
        public int AddressTypeId { get; set; }

        public string HouseNo { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Zip { get; set; }
    }
}
