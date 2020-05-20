using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EpidemicTracker.Data.Models
{
    public class Patient : BaseEntity
    {
        public int OccupationId { get; set; }
        [ForeignKey("OccupationId")]
        public Occupations Occupations { get; set; }
        //public int Id { get; set; }
        public int Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string UniqueId { get; set; }
        public string Password { get; set; }
        //public bool IsActive { get; set; }
        //public DateTime DateCreated { get; set; }
        //public DateTime DateModified { get; set; }
        
    }
}
