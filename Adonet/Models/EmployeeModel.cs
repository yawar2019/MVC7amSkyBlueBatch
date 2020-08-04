using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace Adonet.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
    }

    public class EmployeeDetail
    {
        SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=true");
        public List<EmployeeModel> getEmployeee() {

            List<EmployeeModel> listobj = new List<EmployeeModel>();
            SqlCommand cmd = new SqlCommand("spr_getEmployeeDetails",con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EmployeeModel obj = new EmployeeModel();
                obj.EmpId =Convert.ToInt32(dr["EmpId"]);
                obj.EmpName = Convert.ToString(dr["EmpName"]); ;
                obj.EmpSalary = Convert.ToInt32(dr["EmpSalary"]);

                listobj.Add(obj);
            }

            return listobj;
        }

        public int SaveEmployeee(EmployeeModel obj)
        {
            SqlCommand cmd = new SqlCommand("spr_insertEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@EmpName",obj.EmpName);
            cmd.Parameters.AddWithValue("@EmpSalary",obj.EmpSalary);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}