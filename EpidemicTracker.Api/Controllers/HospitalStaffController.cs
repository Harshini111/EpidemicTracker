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
    public class HospitalStaffController : ControllerBase
    {
        private ILogger<HospitalStaffController> _logger;
        private ETDbContext _context;

        public HospitalStaffController(ILogger<HospitalStaffController> logger, ETDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        [Route("addhospitalstaff")]
        [HttpPost]
        public HospitalStaff AddHospitalStaff([FromBody] HospitalStaff hospitalStaff)
        {
            _context.HospitalStaff.Add(hospitalStaff);
            _context.SaveChanges();
            return hospitalStaff;
        }
    }
}