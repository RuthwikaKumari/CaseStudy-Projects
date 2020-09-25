using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AssnWCFWebClient.ServiceReference1;

namespace AssnWCFWebClient
{
    public partial class ClientForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                AssnServiceClient proxy = new AssnServiceClient();
                var result = proxy.GetCategoryIds().ToList();
                DropDownList1.DataSource = result;
                //DropDownList1.DataTextField = "Category_ID";
                DropDownList1.DataBind();
            }
            
        }
        protected void bttnEnter_Click(object sender, EventArgs e)
        {
            string CategoryId = DropDownList1.SelectedValue;
            AssnServiceClient proxy = new AssnServiceClient();
            var result = proxy.GetProductsonId(CategoryId).ToList();
            GridView1.DataSource = result;
            GridView1.DataBind();
        }
    }
}