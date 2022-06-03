using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeLeaveLogger
{
    
    public class EmployeeLeaveTracking
    {
        public EmployeeLeaveTracking()
        {

        }
        public EmployeeLeaveTracking(string FirstName,string LastName,bool Gender,DateTime Holiday,int EmployeeID,int LeaveBalance,string EmailAddress)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.HolidayDay = Holiday;
            this.EmployeeID = EmployeeID;
            this.LeaveBalance = LeaveBalance;
            this.EmailAddress = EmailAddress;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool   Gender { get; set; }
        public DateTime HolidayDay { get; set; }
        public int EmployeeID { get; set; }
        public int LeaveBalance { get; set; }
        public string EmailAddress { get; set; }
    }
}
