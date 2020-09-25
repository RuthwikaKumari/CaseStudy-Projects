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
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Parent prnt = new Parent
            {
                ParentName = txtusername.Text,
                Password = txtpassword.Text
            };
            BussinessLayer bl = new BussinessLayer();
            bool value = bl.LoginUser(prnt);
            if(value==true)
                Response.Redirect("~/Messages.aspx");
            else
            {
                txtmsg.Text = "This UserName doesn't exist. Please Register to Login";
            }
           
        }
    }
}