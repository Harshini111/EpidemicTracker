using EpidemicTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpidemicTracker.Api.ViewModels
{
    public class TreatmentViewModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public int DiseaseId { get; set; }
        public int DiseaseTypeId { get; set; }
        public int TreatmentStatusId { get; set; }
        public DateTime AdmittedOn { get; set; }
        public DateTime RelievingOn { get; set; }
        public PrescriptionViewModel patientPrescription { get; set; }
    }
}
