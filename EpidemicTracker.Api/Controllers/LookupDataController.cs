using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EpidemicTracker.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.TraceSource;

namespace EpidemicTracker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookupDataController : ControllerBase
    {
        private readonly ILogger<LookupDataController> logger;
        private ETDbContext context;
        private ILogger<LookupDataController> _logger;
        private ETDbContext _context;

        public LookupDataController(ILogger<LookupDataController> logger, ETDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        [Route("getdiseasetypes")]
        [HttpGet]
        public IEnumerable<DiseaseType> GetDiseaseTypes()
        {
            return _context.DiseaseType.ToList();

        }
        [Route("getdisease")]
        [HttpGet]
        public IEnumerable<DiseaseDetails> GetDiseases()
        {
            return _context.DiseaseDetails.ToList();
        }
        [Route("getaddresstypes")]
        [HttpGet]
        public IEnumerable<AddressTypes> GetAddressTypes()
        {
            return _context.AddressTypes.ToList();
        }
        [Route("getoccupation")]
        [HttpGet]
        public IEnumerable<Occupations> GetOccupations()
        {
            return _context.Occupations.ToList();
        }
        [Route("getstaffrole")]
        [HttpGet]
        public IEnumerable<StaffRole> GetStaffRoles()
        {
            return _context.StaffRole.ToList();
        }
        [Route("gettreatmentstatus")]
        [HttpGet]
        public IEnumerable<TreatmentStatus> GetTreatmentStatuses()
        {
            return _context.TreatmentStatus.ToList();
        }
    }
}