using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Employee.Website.Models;

namespace Employee.Website.Services
{
    public class JsonFileEmployeeService
    {
        public JsonFileEmployeeService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "employees.json"); }
        }

        public IEnumerable<Employees> GetEmployee()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Employees[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
        public Employees GetEmployeeById(int employeeId)
        {
            var employee = GetEmployee();
            return employee.First(x => x.Id == employeeId);

        }
        public void DeleteEmployeeById(int employeeId)
        {
            var employees = GetEmployee().ToList();

            employees.Remove(employees.First(x => x.Id == employeeId));


            using (var outputStream = File.Create(JsonFileName))
            {
                System.Text.Json.JsonSerializer.Serialize<List<Employees>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }),
                   employees);

            }

        }


        public void AddEmployee(Employees employee )                   //, string eFirstName) //, string eLastName, string eGender, string eEmail, long ePhone, string eAddress, string eAbout)

        {
            var addEmployees = GetEmployee().ToList();

            addEmployees.Add(employee);

            using (var outputStream = File.Create(JsonFileName))
            {
                System.Text.Json.JsonSerializer.Serialize<List<Employees>>(
                 new Utf8JsonWriter(outputStream, new JsonWriterOptions
                 {
                     SkipValidation = true,
                     Indented = true
                 }),
                addEmployees);

            }
        }
    }
}

