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
    public partial class Messages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Message msg = new Message
            {
               ParentName=TextBox3.Text,
               Subject=txtSub.Text,
               message=TextBox2.Text
            };
            BussinessLayer bl = new BussinessLayer();
            bl.PostMessage(msg);
        }
    }
}