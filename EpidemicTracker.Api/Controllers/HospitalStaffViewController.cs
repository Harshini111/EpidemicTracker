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
    public class HospitalStaffViewController : ControllerBase
    {
        private ILogger<HospitalStaffViewController> _logger;
        private ETDbContext _context;

        public HospitalStaffViewController(ILogger<HospitalStaffViewController> logger, ETDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        [Route("addHospitalStaffDetails")]
        [HttpPost]
        public HospitalStaffViewModel AddHospitalStaff([FromBody] HospitalStaffViewModel hospitalStaffViewModel)
        {
            HospitalStaff hospitalStaff = new HospitalStaff()
            {
                Id = hospitalStaffViewModel.Id,
                IsActive = true,
                DateCreated = DateTime.UtcNow,
                DateModified = DateTime.UtcNow,
                Name = hospitalStaffViewModel.Name,
                HospitalId = hospitalStaffViewModel.HospitalId,
                StaffRoleId = hospitalStaffViewModel.StaffRoleId,
                Phone = hospitalStaffViewModel.Phone,
                Age = hospitalStaffViewModel.Age,
                Gender = hospitalStaffViewModel.Gender,
                UniqueId = hospitalStaffViewModel.UniqueId,
                AddressLine = hospitalStaffViewModel.AddressLine,
                Area = hospitalStaffViewModel.Area,
                City = hospitalStaffViewModel.City,
                State = hospitalStaffViewModel.State,
                Pincode = hospitalStaffViewModel.Pincode,
                District = hospitalStaffViewModel.District,
                Country = hospitalStaffViewModel.Country,
                Username = hospitalStaffViewModel.Username,
                Password = hospitalStaffViewModel.Password           
            };

            _context.HospitalStaff.Add(hospitalStaff);
            _context.SaveChanges();

            hospitalStaffViewModel.Id = hospitalStaff.Id;
            hospitalStaffViewModel.HospitalId = hospitalStaff.HospitalId;
            hospitalStaffViewModel.StaffRoleId = hospitalStaff.StaffRoleId;

            return hospitalStaffViewModel;
        }
    }
}