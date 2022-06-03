using DocuSign.eSign.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeLeaveLogger
{
    public class EmployeeDataLayer
    {
        public List<EmployeeLeaveTracking> EmployeeDataById(string queryString,
            string connectionString, int employeeID)
        {
            try
            {
                DataTable dt = new DataTable();
                EmployeeLeaveTracking e = new EmployeeLeaveTracking();
                List<EmployeeLeaveTracking> employeeList = new List<EmployeeLeaveTracking>();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(queryString, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@employeeid", employeeID);
                        cmd.ExecuteNonQuery();

                        //myReader = cmd.ExecuteReader();
                        dt.Load(cmd.ExecuteReader());
                        foreach (DataRow d in dt.Rows)
                        {
                            e.FirstName = d["FirstName"].ToString();
                            e.LastName = d["LastName"].ToString();
                            e.Gender = Convert.ToBoolean(d["Gender"]);
                            e.EmployeeID = Convert.ToInt32(d["EmployeeID"]);
                            e.EmailAddress = d["EmailAddress"].ToString();
                            e.HolidayDay = Convert.ToDateTime(d["HolidayDay"]);
                            e.LeaveBalance = Convert.ToInt32(d["LeaveBalance"]);
                            employeeList.Add(e);
                        }
                        con.Close();
                     }

                     return employeeList;
                 }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            }
        }

        //private static void CreateCommand(string queryString,
        //    string connectionString)
        //{
        //    using (SqlConnection connection = new SqlConnection(
        //               connectionString))
        //    {
        //        SqlCommand command = new SqlCommand(queryString, connection);
        //        command.Connection.Open();
        //        command.ExecuteNonQuery();
        //    }
        //}
    }
