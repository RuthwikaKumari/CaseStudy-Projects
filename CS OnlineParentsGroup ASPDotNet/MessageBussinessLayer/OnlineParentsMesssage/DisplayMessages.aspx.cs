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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string subject = Request.QueryString.Get("Subject");
            BussinessLayer bl = new BussinessLayer();
            List<Message> lstmsg = bl.GetMessagesBySubject(subject);
            GridView1.DataSource = lstmsg;
            GridView1.DataBind();
        }
    }
}