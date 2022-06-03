using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeLeaveLogger.Controllers
{
    [ApiController]
    [Route("Employee")]
    public class EmployeeLogger : ControllerBase
    {

        private readonly IConfiguration _configuration;
        public EmployeeLogger(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // GET: EmployeeLogger
        [HttpGet]
        [RouteAttribute("GetAllEmployeeDetails")]
        public IEnumerable<EmployeeLeaveTracking> Get()
        {
            try
            {
                int employeeid = 1;
                var rng = new Random();
                var connectionstring = _configuration.GetConnectionString("EmployeeAppCon");
                EmployeeBusinessLayer e = new EmployeeBusinessLayer();
                var employee = e.GetEmployeebyID(employeeid, connectionstring);
                return employee;
            }
            catch(Exception ex)
            {
                throw ex;
            }
         
        }


        //[HttpGet]
        //[RouteAttribute("GetEmployeebyID")]
        //public IEnumerable<EmployeeLeaveTracking> GetEmployeebyID()
        //{
        //    EmployeeAllData e = new EmployeeAllData();
        //    return Enumerable.Range(1, 1).Select(index => new EmployeeLeaveTracking
        //    {
        //    }).ToArray();
        //}

    }
}
