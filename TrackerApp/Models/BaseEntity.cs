using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EpidemicTracker.Data.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        [Required]
        public int IsActive { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        public DateTime DateModified { get; set; }
    }
}
