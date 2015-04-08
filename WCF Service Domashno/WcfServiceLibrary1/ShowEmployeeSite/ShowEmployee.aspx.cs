using ShowEmployeeSite.EmployeeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShowEmployeeSite
{
    public partial class ShowEmployee : System.Web.UI.Page
    {
        Service1Client employeeSvc = new Service1Client();// iNstanciranje na  Service1client
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {              

                GridView1.DataSource = employeeSvc.GetEmployeesData();
                GridView1.DataBind();
            }
        }

        public static int i = 3;
        protected void Button1_Click(object sender, EventArgs e)
        {
            i += 1;
            Employee objcust =
            new Employee()
            {
                EmployeeID = i,
                FirstName = TextBox1.Text,
                LastName = TextBox2.Text,
                Age = Convert.ToInt32(TextBox3.Text)
            };

            employeeSvc.InsertEmployee(objcust);

            GridView1.DataSource = employeeSvc.GetEmployeesData();
            GridView1.DataBind();
            Label1.Text = "Record Saved Successfully";
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int userid = Convert.ToInt32(GridView1.DataKeys
            [e.RowIndex].Values["EmployeeID"].ToString());
            employeeSvc = new Service1Client();

            bool check = employeeSvc.DeleteEmployee(userid);
            Label1.Text = "Record Deleted Successfully";
            GridView1.DataSource = employeeSvc.GetEmployeesData();
            GridView1.DataBind();
        }

    }
}