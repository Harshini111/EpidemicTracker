using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EpidemicTracker.Data.Models
{
    public class Treatment : BaseEntity
    {
        //public int Id {get; set;}
        public int PatientId { get; set; }
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }
        public int DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public HospitalStaff HospitalStaff { get; set; }
        public int DiseaseId { get; set; }
        [ForeignKey("DiseaseId")]
        public DiseaseDetails DiseaseDetails { get; set; }
        public int DiseaseTypeId { get; set; }
        [ForeignKey("DiseaseTypeId")]
        public DiseaseType DiseaseType { get; set; }
        public int TreatmenStatusId { get; set; }
        [ForeignKey("TreatmenStatusId")]
        public TreatmentStatus TreatmentStatus { get; set; }
        public DateTime AdmittedOn { get; set; }
        public DateTime RelievingOn { get; set; }
        //public bool IsActive { get; set; }
        //public DateTime DateCreated { get; set; }
        //public DateTime DateModified { get; set; }
    }
}
