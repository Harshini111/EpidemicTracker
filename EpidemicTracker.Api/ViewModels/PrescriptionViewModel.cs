using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpidemicTracker.Api.ViewModels
{
    public class PrescriptionViewModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int TreatmentId { get; set; }
        public string Notes { get; set; }
    }
}
