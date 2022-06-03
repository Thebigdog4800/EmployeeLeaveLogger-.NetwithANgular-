using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeLeaveLogger
{
    public class EmployeeBusinessLayer
    {
        public  List<EmployeeLeaveTracking> GetEmployeebyID(int employeeid,string connectionstring)
        {
            try
            {
                EmployeeDataLayer e = new EmployeeDataLayer();
                var employee = e.EmployeeDataById("GetEmployeebyID", connectionstring, employeeid);
                return employee;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
