using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFWindowsFormsClient.ServiceReference1;

namespace WCFWindowsFormsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            int Number = int.Parse(TBNum.Text);
            EmpServiceClient proxy = new EmpServiceClient();
            string result = proxy.GetData(Number);
            txtMsg.Text = result;
        }
    }
}
