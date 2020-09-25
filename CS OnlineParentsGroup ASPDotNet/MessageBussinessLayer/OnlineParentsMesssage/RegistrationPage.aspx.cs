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
    public partial class RegistrationPage : System.Web.UI.Page
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
                bool value = bl.UserNameExists(prnt.ParentName);
                if (value == true)
                {
                    Label1.Text = "This UserName already exists";
                }
                else
                {
                    bl.RegisterUser(prnt);
                    Label1.Text = "Registration Sucessfull. You can post your Message";
                }
           
        }
    }
}