using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFWebApplicationClient.ServiceReference1;

namespace WCFWebApplicationClient
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

        protected void ButtonEnter_Click(object sender, EventArgs e)
        {
            //int Number = int.Parse(TBNum.Text);
            //EmpServiceClient proxy = new EmpServiceClient();
            //string result = proxy.GetData(Number);
            //txtMsg.Text = result;
        }
    }
}