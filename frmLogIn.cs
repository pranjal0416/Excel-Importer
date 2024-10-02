using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_Stuff
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();

            this.lblHint.Visible = false;
            this.lblHint.Text = "Username is like u*er and password is like pas**ord";
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            if(this.lblHint.Visible == false)
            {
                this.lblHint.Visible = true;
            }
            else
            {
                this.lblHint.Visible = false;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(this.txtUsername.Text == "user" && this.txtPassword.Text == "password")
            {
                this.Hide();
                Application.DoEvents();
                this.Refresh();

                frmMain frm = new frmMain();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect");
            }
            

            
        }
    }
}
