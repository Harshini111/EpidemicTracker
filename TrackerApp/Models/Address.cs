using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EpidemicTracker.Data.Models
{
    public class Address : BaseEntity
    {
        //public int Id { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set;}
        public int AddressTypeId { get; set; }
        [ForeignKey("AddressTypeId")]
        public AddressTypes AddressTypes {get; set;}
        public string HouseNo { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Country { get; set; }
        //public bool IsActive { get; set; }
        //public DateTime DateCreated { get; set; }
        //public DateTime DateModified { get; set; }
    }
}
