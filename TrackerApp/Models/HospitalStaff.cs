using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EpidemicTracker.Data.Models
{
    public class HospitalStaff : BaseEntity
    {
        //public int Id {get; set;}
        public int HospitalId { get; set; }
        [ForeignKey("HospitalId")]
        public Hospital Hospital { get; set; }
        public string Name { get; set; }
        public int StaffRoleId { get; set; }
        [ForeignKey("StaffRoleId")]
        public StaffRole StaffRole { get; set; }
        //public bool IsActive { get; set; }
        //public DateTime DateCreated { get; set; }
        //public DateTime DateModified { get; set; }
    }
}
