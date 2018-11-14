using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeBookApp
{
    public partial class StartingForm : Form
    {
        Login formaLogin;
        public StartingForm()
        {
            InitializeComponent();

            userControl_Classes1.Visible = false;

        }

        private void btn_ExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_ManageClasses_Click(object sender, EventArgs e)
        {
            userControl_Classes1.BringToFront();
            userControl_Classes1.Visible = true;
            
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            // @TODO: open new form for log in

            if (formaLogin == null)
            {
                formaLogin = new Login();
            }

            formaLogin.Show();
            formaLogin.BringToFront();
            formaLogin.Focus();
            formaLogin.Activate();

            
        }
    }
}
