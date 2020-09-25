using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFWebAppClient.ServiceReference2;


namespace WCFWebAppClient
{
    public partial class ClientForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                EmpServiceClient proxy = new EmpServiceClient();
                var result = proxy.GetAllEmps().ToList();
                GridView1.DataSource = result;
                GridView1.DataBind();
            }
        }
        protected void bttnAddEmp_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                Ecode = int.Parse(TBEcode.Text),
                Ename = TBEname.Text,
                Salary = int.Parse(TBSalary.Text),
                Deptid = int.Parse(TBDeptId.Text)
            };
            EmpServiceClient proxy = new EmpServiceClient();
            proxy.AddEmployee(emp);
            txtMsg.Text = "Record inserted";
            var result = proxy.GetAllEmps().ToList();
            GridView1.DataSource = result;
            GridView1.DataBind();
        }
        protected void bttnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int ecode = int.Parse(TBEcode.Text);
                EmpServiceClient proxy = new EmpServiceClient();
                proxy.DeleteEmployee(ecode);
                txtMsg.Text = "Record Deleted";
                var result = proxy.GetAllEmps().ToList();
                GridView1.DataSource = result;
                GridView1.DataBind();
            }
            catch(Exception ex)
            {
                txtMsg.Text = ex.Message;
            }
        }
        protected void bttnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int ecode = int.Parse(TBEcode.Text);
                int salary = int.Parse(TBSalary.Text);
                EmpServiceClient proxy = new EmpServiceClient();
                proxy.UpdateEmpbyEcode(ecode, salary);
                txtMsg.Text = "Record Updated";

                var result = proxy.GetAllEmps().ToList();
                GridView1.DataSource = result;
                GridView1.DataBind();
            }
            catch(Exception ex)
            {
                txtMsg.Text = ex.Message;
            }
        }
        protected void bttnFindbyEcode_Click(object sender, EventArgs e)
        {
            int Ecode = int.Parse(TBEcode.Text);
            EmpServiceClient proxy = new EmpServiceClient();
            Employee emp =  proxy.GetEmpbyEcode(Ecode);
            if (emp != null)
            {
                TBEname.Text = emp.Ename;
                TBSalary.Text = emp.Salary.ToString();
                TBDeptId.Text = emp.Deptid.ToString();
            }
            else
            {
                txtMsg.Text = ("Ecode not present");
            }
        }
    }
}