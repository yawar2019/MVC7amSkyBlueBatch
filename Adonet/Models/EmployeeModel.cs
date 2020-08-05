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
        public List<EmployeeModel> getEmployeee()
        {

            List<EmployeeModel> listobj = new List<EmployeeModel>();
            SqlCommand cmd = new SqlCommand("spr_getEmployeeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EmployeeModel obj = new EmployeeModel();
                obj.EmpId = Convert.ToInt32(dr["EmpId"]);
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
            cmd.Parameters.AddWithValue("@EmpName", obj.EmpName);
            cmd.Parameters.AddWithValue("@EmpSalary", obj.EmpSalary);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public EmployeeModel GetEmployeeById(int? id)
        {
            EmployeeModel obj = new EmployeeModel();
            SqlCommand cmd = new SqlCommand("spr_getEmployeeDetailsbyId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empid", id);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                obj.EmpId = Convert.ToInt32(dr["EmpId"]);
                obj.EmpName = Convert.ToString(dr["EmpName"]); ;
                obj.EmpSalary = Convert.ToInt32(dr["EmpSalary"]);
            }

            return obj;
        }


        public int UpdateEmployeee(EmployeeModel obj)
        {
            SqlCommand cmd = new SqlCommand("spr_updateEmployeeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@empid", obj.EmpId);
            cmd.Parameters.AddWithValue("@empname", obj.EmpName);
            cmd.Parameters.AddWithValue("@empsalary", obj.EmpSalary);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public int DeleteEmployee(int? id)
        {
            SqlCommand cmd = new SqlCommand("spr_deleteEmployeeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@empid", id);
             
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        
    }
}