using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace EpidemicTracker.Data.Models
{
    public class Hospital : BaseEntity
    {
        //public int Id {get; set;}
        public string Name { get; set; }
        public string Phone { get; set; }
        public string HospitalAddress { get; set; }
        //public bool IsActive { get; set; }
        //public DateTime DateCreated { get; set; }
        //public DateTime DateModified { get; set; }

    }
}
