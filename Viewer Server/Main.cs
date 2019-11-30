using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viewer_Server
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(txtPort1.Text.ToString().Trim() == "")
            {
                txtPort1.Focus();
            }
            else if (txtPort2.Text.ToString().Trim() == "")
            {
                txtPort2.Focus();
            }
            else if (txtPort3.Text.ToString().Trim() == "")
            {
                txtPort3.Focus();
            }
            else if (txtPort4.Text.ToString().Trim() == "")
            {
                txtPort4.Focus();
            }
            else
            {
                new ScreenView(int.Parse(txtPort1.Text), int.Parse(txtPort2.Text), int.Parse(txtPort3.Text), int.Parse(txtPort4.Text)).Show();
                btnConnect.Enabled = false;
            }
            
            
        }
    }
}
