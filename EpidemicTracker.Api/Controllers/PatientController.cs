using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EpidemicTracker.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EpidemicTracker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private ILogger<PatientController> _logger;
        private ETDbContext _context;

        public PatientController(ILogger<PatientController> logger, ETDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        [Route("addpatient")]
        [HttpPost]
        public Patient AddPatient([FromBody] Patient patient)
        {
            _context.Patient.Add(patient);
            _context.SaveChanges();
            return patient;
        }
    }
}