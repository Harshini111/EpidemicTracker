using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EpidemicTracker.Api.ViewModels;
using EpidemicTracker.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EpidemicTracker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientViewController : ControllerBase
    {
        private ILogger<PatientViewController> _logger;
        private ETDbContext _context;

        public PatientViewController(ILogger<PatientViewController> logger, ETDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        [Route("addPatientDetails")]
        [HttpPost]
        public PatientViewModel AddPatient([FromBody] PatientViewModel patientViewModel)
        {
            Patient patient = new Patient()
            {
                IsActive = true,
                DateCreated = DateTime.UtcNow,
                DateModified = DateTime.UtcNow,
                Id = patientViewModel.Id,
                FirstName = patientViewModel.FirstName,
                LastName = patientViewModel.LastName,
                Age = patientViewModel.Age,
                Gender = patientViewModel.Gender,
                Phone = patientViewModel.Phone,
                UniqueId = patientViewModel.UniqueId,
                Username = patientViewModel.Username,
                Password = patientViewModel.Password,
                OccupationId = patientViewModel.OccupationId
            };

            _context.Patient.Add(patient);
            _context.SaveChanges();

            var permanentAddress = new Address()
            {
                IsActive = true,
                DateCreated = DateTime.UtcNow,
                DateModified = DateTime.UtcNow,
                AddressTypeId = 1,
                PatientId = patient.Id,
                HouseNo = patientViewModel.permanentAddress.HouseNo,
                Area = patientViewModel.permanentAddress.Area,
                City = patientViewModel.permanentAddress.City,
                State = patientViewModel.permanentAddress.State,
                District = patientViewModel.permanentAddress.District,
                Zip = patientViewModel.permanentAddress.Zip,
                Country = patientViewModel.permanentAddress.Country,
            };
            _context.Address.Add(permanentAddress);
            _context.SaveChanges();

            var currentAddress = new Address()
            {

                IsActive = true,
                DateCreated = DateTime.UtcNow,
                DateModified = DateTime.UtcNow,
                AddressTypeId = 2,
                PatientId = patient.Id,
                HouseNo = patientViewModel.currentAddress.HouseNo,
                Area = patientViewModel.currentAddress.Area,
                City = patientViewModel.currentAddress.City,
                State = patientViewModel.currentAddress.State,
                District = patientViewModel.currentAddress.District,
                Zip = patientViewModel.currentAddress.Zip,
                Country = patientViewModel.currentAddress.Country
            };
            _context.Address.Add(currentAddress);
            _context.SaveChanges();

            var occupationAddress = new Address()
            {
                IsActive = true,
                DateCreated = DateTime.UtcNow,
                DateModified = DateTime.UtcNow,
                AddressTypeId = 3,
                PatientId = patient.Id,
                HouseNo = patientViewModel.occupationAddress.HouseNo,
                Area = patientViewModel.occupationAddress.Area,
                City = patientViewModel.occupationAddress.City,
                State = patientViewModel.occupationAddress.State,
                District = patientViewModel.occupationAddress.District,
                Zip = patientViewModel.occupationAddress.Zip,
                Country = patientViewModel.occupationAddress.Country
            };
            _context.Address.Add(occupationAddress);
            _context.SaveChanges();

            patientViewModel.Id = patient.Id;
            patientViewModel.permanentAddress.PatientId = patient.Id;
            patientViewModel.currentAddress.PatientId = patient.Id;
            patientViewModel.occupationAddress.PatientId = patient.Id;
            patientViewModel.permanentAddress.AddressTypeId = 1;
            patientViewModel.currentAddress.AddressTypeId = 2;
            patientViewModel.occupationAddress.AddressTypeId = 3;

            return patientViewModel;
        }
        // GET: api/Patient
        //[Route("patientdetails")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Patient>>> GetPatients()
        {
            return await _context.Patient.ToListAsync();
        }
        // GET: api/Patient/5
        //[Route("patientdetailsById")]
        [HttpGet("{id}")]
        public async Task<ActionResult<Patient>> GetPatient(int id)
        {
            var patient = await _context.Patient.FindAsync(id);

            if (patient == null)
            {
                return NotFound();
            }

            return patient;
        }

        /*//GET: api/Treatment
        [HttpGet("{id")]
        public async Task<ActionResult<Treatment>> GetTreatment(int id)
        {
            var treatment = await _context.Treatment.FindAsync(id );
            if (treatment == null)
            {
                return NotFound();
            }
            return treatment;
        }
        private bool TodoItemExists(long id)
        {
            return _context.TodoItems.Any(e => e.Id == id);
        }*/
    }
}