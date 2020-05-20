using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EpidemicTracker.Data.Models
{
    public class Prescription : BaseEntity
    {
        //public int Id {get; set;}
        public int TreatmenId { get; set; }
        [ForeignKey("TreatmenId")]
        public Treatment Treatment { get; set; }
        public string Notes { get; set; }
        //public bool IsActive { get; set; }
        //public DateTime DateCreated { get; set; }
        //public DateTime DateModified { get; set; }
    }
}
