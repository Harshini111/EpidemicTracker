﻿using System;
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
    public class PrescriptionController : ControllerBase
    {
        private ILogger<PrescriptionController> _logger;
        private ETDbContext _context;

        public PrescriptionController(ILogger<PrescriptionController> logger, ETDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        [Route("addprescription")]
        [HttpPost]
        public Prescription AddPrescription([FromBody] Prescription prescription)
        {
            _context.Prescription.Add(prescription);
            _context.SaveChanges();
            return prescription;
        }
    }
}