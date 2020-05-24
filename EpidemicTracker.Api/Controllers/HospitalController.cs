using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EpidemicTracker.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EpidemicTracker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private ILogger<HospitalController> _logger;
        private ETDbContext _context;

        public HospitalController(ILogger<HospitalController> logger, ETDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [Route("addhospital")]
        [HttpPost]
        public Hospital AddHospital([FromBody] Hospital hospital)
        {
            _context.Hospital.Add(hospital);
            _context.SaveChanges();
            return hospital;
        }
    }
}