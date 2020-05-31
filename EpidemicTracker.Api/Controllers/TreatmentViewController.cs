using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EpidemicTracker.Api.ViewModels;
using EpidemicTracker.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EpidemicTracker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentViewController : ControllerBase
    {
        private ILogger<TreatmentViewController> _logger;
        private ETDbContext _context;

        public TreatmentViewController(ILogger<TreatmentViewController> logger, ETDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        [Route("addTreatmentDetails")]
        [HttpPost]
        public TreatmentViewModel AddTreatment([FromBody] TreatmentViewModel treatmentViewModel)
        {
            Treatment treatment = new Treatment()
            {
                IsActive = true,
                DateCreated = DateTime.UtcNow,
                DateModified = DateTime.UtcNow,
                PatientId = treatmentViewModel.PatientId,
                DoctorId = treatmentViewModel.DoctorId,
                DiseaseId = treatmentViewModel.DiseaseId,
                DiseaseTypeId = treatmentViewModel.DiseaseTypeId,
                TreatmentStatusId = treatmentViewModel.TreatmentStatusId,
                AdmittedOn = treatmentViewModel.AdmittedOn,
                RelievingOn = treatmentViewModel.RelievingOn
            };
            _context.Treatment.Add(treatment);
            _context.SaveChanges();

            var PrescriptionDetails = new Prescription()
            {
                IsActive = true,
                DateCreated = DateTime.UtcNow,
                DateModified = DateTime.UtcNow,
                TreatmentId = treatment.Id,
                Notes = treatmentViewModel.patientPrescription.Notes
            };
            _context.Prescription.Add(PrescriptionDetails);
            _context.SaveChanges();

            treatmentViewModel.Id = treatment.Id;
            treatmentViewModel.PatientId = treatment.PatientId;
            treatmentViewModel.DoctorId = treatment.DoctorId;
            treatmentViewModel.DiseaseId = treatment.DiseaseId;
            treatmentViewModel.DiseaseTypeId = treatment.DiseaseTypeId;
            treatmentViewModel.TreatmentStatusId = treatment.TreatmentStatusId;
            treatmentViewModel.patientPrescription.TreatmentId = treatment.Id;

            return treatmentViewModel;
        }
    }
}