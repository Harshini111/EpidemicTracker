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
    public class TreatmentController : ControllerBase
    {
        private ILogger<TreatmentController> _logger;
        private ETDbContext _context;

        public TreatmentController(ILogger<TreatmentController> logger, ETDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        [Route("addtreatment")]
        [HttpPost]
        public Treatment AddTreatment([FromBody] Treatment treatment)
        {
            _context.Treatment.Add(treatment);
            _context.SaveChanges();
            return treatment;
        }
    }
}