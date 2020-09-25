using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MessageEntities;
using MessageBussinessLayer;

namespace OnlineParentsMesssage
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BussinessLayer bl = new BussinessLayer();
            List<Message> Subjects = bl.GetAllSubjects();
            DropDownList1.DataSource = Subjects;
            DropDownList1.DataTextField = "Subject";
            DropDownList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("~/DisplayMessages.aspx?Subject=" +DropDownList1.Text );
        }
    }
}